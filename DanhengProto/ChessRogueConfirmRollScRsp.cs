using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001FD RID: 509
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueConfirmRollScRsp : IMessage<ChessRogueConfirmRollScRsp>, IMessage, IEquatable<ChessRogueConfirmRollScRsp>, IDeepCloneable<ChessRogueConfirmRollScRsp>, IBufferMessage
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000410EB File Offset: 0x0003F2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueConfirmRollScRsp> Parser
		{
			get
			{
				return ChessRogueConfirmRollScRsp._parser;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x000410F2 File Offset: 0x0003F2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueConfirmRollScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00041104 File Offset: 0x0003F304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueConfirmRollScRsp.Descriptor;
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0004110B File Offset: 0x0003F30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollScRsp()
		{
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00041114 File Offset: 0x0003F314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollScRsp(ChessRogueConfirmRollScRsp other) : this()
		{
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00041160 File Offset: 0x0003F360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollScRsp Clone()
		{
			return new ChessRogueConfirmRollScRsp(this);
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00041168 File Offset: 0x0003F368
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00041170 File Offset: 0x0003F370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo RogueDiceInfo
		{
			get
			{
				return this.rogueDiceInfo_;
			}
			set
			{
				this.rogueDiceInfo_ = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00041179 File Offset: 0x0003F379
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00041181 File Offset: 0x0003F381
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

		// Token: 0x060016B4 RID: 5812 RVA: 0x0004118A File Offset: 0x0003F38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueConfirmRollScRsp);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00041198 File Offset: 0x0003F398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueConfirmRollScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000411E8 File Offset: 0x0003F3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
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

		// Token: 0x060016B7 RID: 5815 RVA: 0x0004123D File Offset: 0x0003F43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00041245 File Offset: 0x0003F445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00041250 File Offset: 0x0003F450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000412AC File Offset: 0x0003F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
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

		// Token: 0x060016BB RID: 5819 RVA: 0x00041304 File Offset: 0x0003F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueConfirmRollScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0004136C File Offset: 0x0003F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00041378 File Offset: 0x0003F578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueDiceInfo_ == null)
					{
						this.RogueDiceInfo = new ChessRogueDiceInfo();
					}
					input.ReadMessage(this.RogueDiceInfo);
				}
			}
		}

		// Token: 0x04000994 RID: 2452
		private static readonly MessageParser<ChessRogueConfirmRollScRsp> _parser = new MessageParser<ChessRogueConfirmRollScRsp>(() => new ChessRogueConfirmRollScRsp());

		// Token: 0x04000995 RID: 2453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000996 RID: 2454
		public const int RogueDiceInfoFieldNumber = 5;

		// Token: 0x04000997 RID: 2455
		private ChessRogueDiceInfo rogueDiceInfo_;

		// Token: 0x04000998 RID: 2456
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000999 RID: 2457
		private uint retcode_;
	}
}
