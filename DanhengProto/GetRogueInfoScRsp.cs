using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C3 RID: 1987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueInfoScRsp : IMessage<GetRogueInfoScRsp>, IMessage, IEquatable<GetRogueInfoScRsp>, IDeepCloneable<GetRogueInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x000ECC2D File Offset: 0x000EAE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueInfoScRsp> Parser
		{
			get
			{
				return GetRogueInfoScRsp._parser;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x000ECC34 File Offset: 0x000EAE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x000ECC46 File Offset: 0x000EAE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x000ECC4D File Offset: 0x000EAE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoScRsp()
		{
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x000ECC58 File Offset: 0x000EAE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoScRsp(GetRogueInfoScRsp other) : this()
		{
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x000ECCA4 File Offset: 0x000EAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInfoScRsp Clone()
		{
			return new GetRogueInfoScRsp(this);
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060058A6 RID: 22694 RVA: 0x000ECCAC File Offset: 0x000EAEAC
		// (set) Token: 0x060058A7 RID: 22695 RVA: 0x000ECCB4 File Offset: 0x000EAEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060058A8 RID: 22696 RVA: 0x000ECCBD File Offset: 0x000EAEBD
		// (set) Token: 0x060058A9 RID: 22697 RVA: 0x000ECCC5 File Offset: 0x000EAEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x000ECCCE File Offset: 0x000EAECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueInfoScRsp);
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x000ECCDC File Offset: 0x000EAEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGameInfo, other.RogueGameInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x000ECD2C File Offset: 0x000EAF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x000ECD81 File Offset: 0x000EAF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x000ECD89 File Offset: 0x000EAF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x000ECD94 File Offset: 0x000EAF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x000ECDF0 File Offset: 0x000EAFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x000ECE48 File Offset: 0x000EB048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new RogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x000ECEB0 File Offset: 0x000EB0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x000ECEBC File Offset: 0x000EB0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueGameInfo_ == null)
						{
							this.RogueGameInfo = new RogueInfo();
						}
						input.ReadMessage(this.RogueGameInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002284 RID: 8836
		private static readonly MessageParser<GetRogueInfoScRsp> _parser = new MessageParser<GetRogueInfoScRsp>(() => new GetRogueInfoScRsp());

		// Token: 0x04002285 RID: 8837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002286 RID: 8838
		public const int RogueGameInfoFieldNumber = 10;

		// Token: 0x04002287 RID: 8839
		private RogueInfo rogueGameInfo_;

		// Token: 0x04002288 RID: 8840
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002289 RID: 8841
		private uint retcode_;
	}
}
