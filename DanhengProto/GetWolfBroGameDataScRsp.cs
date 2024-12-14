using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000853 RID: 2131
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetWolfBroGameDataScRsp : IMessage<GetWolfBroGameDataScRsp>, IMessage, IEquatable<GetWolfBroGameDataScRsp>, IDeepCloneable<GetWolfBroGameDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06005EBC RID: 24252 RVA: 0x000FAAC3 File Offset: 0x000F8CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetWolfBroGameDataScRsp> Parser
		{
			get
			{
				return GetWolfBroGameDataScRsp._parser;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x000FAACA File Offset: 0x000F8CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetWolfBroGameDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06005EBE RID: 24254 RVA: 0x000FAADC File Offset: 0x000F8CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWolfBroGameDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x000FAAE3 File Offset: 0x000F8CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataScRsp()
		{
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x000FAAEC File Offset: 0x000F8CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataScRsp(GetWolfBroGameDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x000FAB38 File Offset: 0x000F8D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataScRsp Clone()
		{
			return new GetWolfBroGameDataScRsp(this);
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x000FAB40 File Offset: 0x000F8D40
		// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x000FAB48 File Offset: 0x000F8D48
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x000FAB51 File Offset: 0x000F8D51
		// (set) Token: 0x06005EC5 RID: 24261 RVA: 0x000FAB59 File Offset: 0x000F8D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x000FAB62 File Offset: 0x000F8D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWolfBroGameDataScRsp);
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x000FAB70 File Offset: 0x000F8D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetWolfBroGameDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x000FABC0 File Offset: 0x000F8DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x000FAC15 File Offset: 0x000F8E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x000FAC1D File Offset: 0x000F8E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x000FAC28 File Offset: 0x000F8E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x000FAC84 File Offset: 0x000F8E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x000FACDC File Offset: 0x000F8EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetWolfBroGameDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x000FAD44 File Offset: 0x000F8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x000FAD50 File Offset: 0x000F8F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.wolfBroGameData_ == null)
						{
							this.WolfBroGameData = new WolfBroGameData();
						}
						input.ReadMessage(this.WolfBroGameData);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002475 RID: 9333
		private static readonly MessageParser<GetWolfBroGameDataScRsp> _parser = new MessageParser<GetWolfBroGameDataScRsp>(() => new GetWolfBroGameDataScRsp());

		// Token: 0x04002476 RID: 9334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002477 RID: 9335
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04002478 RID: 9336
		private uint retcode_;

		// Token: 0x04002479 RID: 9337
		public const int WolfBroGameDataFieldNumber = 13;

		// Token: 0x0400247A RID: 9338
		private WolfBroGameData wolfBroGameData_;
	}
}
