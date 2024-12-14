using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE5 RID: 3813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGetTalentInfoScRsp : IMessage<RogueMagicGetTalentInfoScRsp>, IMessage, IEquatable<RogueMagicGetTalentInfoScRsp>, IDeepCloneable<RogueMagicGetTalentInfoScRsp>, IBufferMessage
	{
		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x001CB30F File Offset: 0x001C950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGetTalentInfoScRsp> Parser
		{
			get
			{
				return RogueMagicGetTalentInfoScRsp._parser;
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x001CB316 File Offset: 0x001C9516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetTalentInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600AA73 RID: 43635 RVA: 0x001CB328 File Offset: 0x001C9528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGetTalentInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x001CB32F File Offset: 0x001C952F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoScRsp()
		{
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x001CB338 File Offset: 0x001C9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoScRsp(RogueMagicGetTalentInfoScRsp other) : this()
		{
			this.rogueMagicTalentInfo_ = ((other.rogueMagicTalentInfo_ != null) ? other.rogueMagicTalentInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x001CB384 File Offset: 0x001C9584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetTalentInfoScRsp Clone()
		{
			return new RogueMagicGetTalentInfoScRsp(this);
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600AA77 RID: 43639 RVA: 0x001CB38C File Offset: 0x001C958C
		// (set) Token: 0x0600AA78 RID: 43640 RVA: 0x001CB394 File Offset: 0x001C9594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicTalentInfo RogueMagicTalentInfo
		{
			get
			{
				return this.rogueMagicTalentInfo_;
			}
			set
			{
				this.rogueMagicTalentInfo_ = value;
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600AA79 RID: 43641 RVA: 0x001CB39D File Offset: 0x001C959D
		// (set) Token: 0x0600AA7A RID: 43642 RVA: 0x001CB3A5 File Offset: 0x001C95A5
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

		// Token: 0x0600AA7B RID: 43643 RVA: 0x001CB3AE File Offset: 0x001C95AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGetTalentInfoScRsp);
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x001CB3BC File Offset: 0x001C95BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGetTalentInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueMagicTalentInfo, other.RogueMagicTalentInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x001CB40C File Offset: 0x001C960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueMagicTalentInfo_ != null)
			{
				num ^= this.RogueMagicTalentInfo.GetHashCode();
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

		// Token: 0x0600AA7E RID: 43646 RVA: 0x001CB461 File Offset: 0x001C9661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x001CB469 File Offset: 0x001C9669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x001CB474 File Offset: 0x001C9674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueMagicTalentInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueMagicTalentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x001CB4D0 File Offset: 0x001C96D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueMagicTalentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueMagicTalentInfo);
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

		// Token: 0x0600AA82 RID: 43650 RVA: 0x001CB528 File Offset: 0x001C9728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGetTalentInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueMagicTalentInfo_ != null)
			{
				if (this.rogueMagicTalentInfo_ == null)
				{
					this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
				}
				this.RogueMagicTalentInfo.MergeFrom(other.RogueMagicTalentInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x001CB590 File Offset: 0x001C9790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x001CB59C File Offset: 0x001C979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueMagicTalentInfo_ == null)
						{
							this.RogueMagicTalentInfo = new RogueMagicTalentInfo();
						}
						input.ReadMessage(this.RogueMagicTalentInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004592 RID: 17810
		private static readonly MessageParser<RogueMagicGetTalentInfoScRsp> _parser = new MessageParser<RogueMagicGetTalentInfoScRsp>(() => new RogueMagicGetTalentInfoScRsp());

		// Token: 0x04004593 RID: 17811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004594 RID: 17812
		public const int RogueMagicTalentInfoFieldNumber = 12;

		// Token: 0x04004595 RID: 17813
		private RogueMagicTalentInfo rogueMagicTalentInfo_;

		// Token: 0x04004596 RID: 17814
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04004597 RID: 17815
		private uint retcode_;
	}
}
