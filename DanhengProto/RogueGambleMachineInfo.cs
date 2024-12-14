using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8B RID: 3723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGambleMachineInfo : IMessage<RogueGambleMachineInfo>, IMessage, IEquatable<RogueGambleMachineInfo>, IDeepCloneable<RogueGambleMachineInfo>, IBufferMessage
	{
		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600A646 RID: 42566 RVA: 0x001BFB0D File Offset: 0x001BDD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGambleMachineInfo> Parser
		{
			get
			{
				return RogueGambleMachineInfo._parser;
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600A647 RID: 42567 RVA: 0x001BFB14 File Offset: 0x001BDD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGambleMachineInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600A648 RID: 42568 RVA: 0x001BFB26 File Offset: 0x001BDD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGambleMachineInfo.Descriptor;
			}
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x001BFB2D File Offset: 0x001BDD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMachineInfo()
		{
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x001BFB38 File Offset: 0x001BDD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMachineInfo(RogueGambleMachineInfo other) : this()
		{
			this.gambleInfo_ = ((other.gambleInfo_ != null) ? other.gambleInfo_.Clone() : null);
			this.eKOLBPJAHCK_ = other.eKOLBPJAHCK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A64B RID: 42571 RVA: 0x001BFB84 File Offset: 0x001BDD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMachineInfo Clone()
		{
			return new RogueGambleMachineInfo(this);
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x001BFB8C File Offset: 0x001BDD8C
		// (set) Token: 0x0600A64D RID: 42573 RVA: 0x001BFB94 File Offset: 0x001BDD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo GambleInfo
		{
			get
			{
				return this.gambleInfo_;
			}
			set
			{
				this.gambleInfo_ = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x001BFB9D File Offset: 0x001BDD9D
		// (set) Token: 0x0600A64F RID: 42575 RVA: 0x001BFBA5 File Offset: 0x001BDDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKOLBPJAHCK
		{
			get
			{
				return this.eKOLBPJAHCK_;
			}
			set
			{
				this.eKOLBPJAHCK_ = value;
			}
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x001BFBAE File Offset: 0x001BDDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGambleMachineInfo);
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x001BFBBC File Offset: 0x001BDDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGambleMachineInfo other)
		{
			return other != null && (other == this || (object.Equals(this.GambleInfo, other.GambleInfo) && this.EKOLBPJAHCK == other.EKOLBPJAHCK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x001BFC0C File Offset: 0x001BDE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gambleInfo_ != null)
			{
				num ^= this.GambleInfo.GetHashCode();
			}
			if (this.EKOLBPJAHCK != 0U)
			{
				num ^= this.EKOLBPJAHCK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x001BFC61 File Offset: 0x001BDE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x001BFC69 File Offset: 0x001BDE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x001BFC74 File Offset: 0x001BDE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gambleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GambleInfo);
			}
			if (this.EKOLBPJAHCK != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EKOLBPJAHCK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x001BFCD0 File Offset: 0x001BDED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gambleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GambleInfo);
			}
			if (this.EKOLBPJAHCK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKOLBPJAHCK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x001BFD28 File Offset: 0x001BDF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGambleMachineInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gambleInfo_ != null)
			{
				if (this.gambleInfo_ == null)
				{
					this.GambleInfo = new RogueGambleInfo();
				}
				this.GambleInfo.MergeFrom(other.GambleInfo);
			}
			if (other.EKOLBPJAHCK != 0U)
			{
				this.EKOLBPJAHCK = other.EKOLBPJAHCK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x001BFD90 File Offset: 0x001BDF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x001BFD9C File Offset: 0x001BDF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EKOLBPJAHCK = input.ReadUInt32();
					}
				}
				else
				{
					if (this.gambleInfo_ == null)
					{
						this.GambleInfo = new RogueGambleInfo();
					}
					input.ReadMessage(this.GambleInfo);
				}
			}
		}

		// Token: 0x04004407 RID: 17415
		private static readonly MessageParser<RogueGambleMachineInfo> _parser = new MessageParser<RogueGambleMachineInfo>(() => new RogueGambleMachineInfo());

		// Token: 0x04004408 RID: 17416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004409 RID: 17417
		public const int GambleInfoFieldNumber = 2;

		// Token: 0x0400440A RID: 17418
		private RogueGambleInfo gambleInfo_;

		// Token: 0x0400440B RID: 17419
		public const int EKOLBPJAHCKFieldNumber = 6;

		// Token: 0x0400440C RID: 17420
		private uint eKOLBPJAHCK_;
	}
}
