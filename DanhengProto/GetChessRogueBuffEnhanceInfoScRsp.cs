using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000659 RID: 1625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueBuffEnhanceInfoScRsp : IMessage<GetChessRogueBuffEnhanceInfoScRsp>, IMessage, IEquatable<GetChessRogueBuffEnhanceInfoScRsp>, IDeepCloneable<GetChessRogueBuffEnhanceInfoScRsp>, IBufferMessage
	{
		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x000C7027 File Offset: 0x000C5227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueBuffEnhanceInfoScRsp> Parser
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoScRsp._parser;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x000C702E File Offset: 0x000C522E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x000C7040 File Offset: 0x000C5240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x000C7047 File Offset: 0x000C5247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoScRsp()
		{
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x000C7050 File Offset: 0x000C5250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoScRsp(GetChessRogueBuffEnhanceInfoScRsp other) : this()
		{
			this.buffEnhanceInfo_ = ((other.buffEnhanceInfo_ != null) ? other.buffEnhanceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x000C709C File Offset: 0x000C529C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueBuffEnhanceInfoScRsp Clone()
		{
			return new GetChessRogueBuffEnhanceInfoScRsp(this);
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x000C70A4 File Offset: 0x000C52A4
		// (set) Token: 0x060048E4 RID: 18660 RVA: 0x000C70AC File Offset: 0x000C52AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceList BuffEnhanceInfo
		{
			get
			{
				return this.buffEnhanceInfo_;
			}
			set
			{
				this.buffEnhanceInfo_ = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x000C70B5 File Offset: 0x000C52B5
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x000C70BD File Offset: 0x000C52BD
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

		// Token: 0x060048E7 RID: 18663 RVA: 0x000C70C6 File Offset: 0x000C52C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueBuffEnhanceInfoScRsp);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x000C70D4 File Offset: 0x000C52D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueBuffEnhanceInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BuffEnhanceInfo, other.BuffEnhanceInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x000C7124 File Offset: 0x000C5324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.buffEnhanceInfo_ != null)
			{
				num ^= this.BuffEnhanceInfo.GetHashCode();
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

		// Token: 0x060048EA RID: 18666 RVA: 0x000C7179 File Offset: 0x000C5379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x000C7181 File Offset: 0x000C5381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x000C718C File Offset: 0x000C538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.buffEnhanceInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.BuffEnhanceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x000C71E8 File Offset: 0x000C53E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.buffEnhanceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffEnhanceInfo);
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

		// Token: 0x060048EE RID: 18670 RVA: 0x000C7240 File Offset: 0x000C5440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueBuffEnhanceInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.buffEnhanceInfo_ != null)
			{
				if (this.buffEnhanceInfo_ == null)
				{
					this.BuffEnhanceInfo = new ChessRogueBuffEnhanceList();
				}
				this.BuffEnhanceInfo.MergeFrom(other.BuffEnhanceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x000C72A8 File Offset: 0x000C54A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x000C72B4 File Offset: 0x000C54B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.buffEnhanceInfo_ == null)
						{
							this.BuffEnhanceInfo = new ChessRogueBuffEnhanceList();
						}
						input.ReadMessage(this.BuffEnhanceInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D11 RID: 7441
		private static readonly MessageParser<GetChessRogueBuffEnhanceInfoScRsp> _parser = new MessageParser<GetChessRogueBuffEnhanceInfoScRsp>(() => new GetChessRogueBuffEnhanceInfoScRsp());

		// Token: 0x04001D12 RID: 7442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D13 RID: 7443
		public const int BuffEnhanceInfoFieldNumber = 10;

		// Token: 0x04001D14 RID: 7444
		private ChessRogueBuffEnhanceList buffEnhanceInfo_;

		// Token: 0x04001D15 RID: 7445
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001D16 RID: 7446
		private uint retcode_;
	}
}
