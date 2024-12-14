using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000339 RID: 825
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CPDLMGKIJLJ : IMessage<CPDLMGKIJLJ>, IMessage, IEquatable<CPDLMGKIJLJ>, IDeepCloneable<CPDLMGKIJLJ>, IBufferMessage
	{
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000680E1 File Offset: 0x000662E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CPDLMGKIJLJ> Parser
		{
			get
			{
				return CPDLMGKIJLJ._parser;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x000680E8 File Offset: 0x000662E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CPDLMGKIJLJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000680FA File Offset: 0x000662FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CPDLMGKIJLJ.Descriptor;
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00068101 File Offset: 0x00066301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CPDLMGKIJLJ()
		{
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0006810C File Offset: 0x0006630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CPDLMGKIJLJ(CPDLMGKIJLJ other) : this()
		{
			this.pGAAILFLGCN_ = other.pGAAILFLGCN_;
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00068158 File Offset: 0x00066358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CPDLMGKIJLJ Clone()
		{
			return new CPDLMGKIJLJ(this);
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00068160 File Offset: 0x00066360
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00068168 File Offset: 0x00066368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PGAAILFLGCN
		{
			get
			{
				return this.pGAAILFLGCN_;
			}
			set
			{
				this.pGAAILFLGCN_ = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x00068171 File Offset: 0x00066371
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00068179 File Offset: 0x00066379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo TournFinishInfo
		{
			get
			{
				return this.tournFinishInfo_;
			}
			set
			{
				this.tournFinishInfo_ = value;
			}
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00068182 File Offset: 0x00066382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CPDLMGKIJLJ);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00068190 File Offset: 0x00066390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CPDLMGKIJLJ other)
		{
			return other != null && (other == this || (this.PGAAILFLGCN == other.PGAAILFLGCN && object.Equals(this.TournFinishInfo, other.TournFinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x000681E0 File Offset: 0x000663E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PGAAILFLGCN != 0U)
			{
				num ^= this.PGAAILFLGCN.GetHashCode();
			}
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00068235 File Offset: 0x00066435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0006823D File Offset: 0x0006643D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00068248 File Offset: 0x00066448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PGAAILFLGCN != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PGAAILFLGCN);
			}
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x000682A4 File Offset: 0x000664A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PGAAILFLGCN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PGAAILFLGCN);
			}
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x000682FC File Offset: 0x000664FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CPDLMGKIJLJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PGAAILFLGCN != 0U)
			{
				this.PGAAILFLGCN = other.PGAAILFLGCN;
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueTournFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00068364 File Offset: 0x00066564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00068370 File Offset: 0x00066570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tournFinishInfo_ == null)
						{
							this.TournFinishInfo = new RogueTournFinishInfo();
						}
						input.ReadMessage(this.TournFinishInfo);
					}
				}
				else
				{
					this.PGAAILFLGCN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F06 RID: 3846
		private static readonly MessageParser<CPDLMGKIJLJ> _parser = new MessageParser<CPDLMGKIJLJ>(() => new CPDLMGKIJLJ());

		// Token: 0x04000F07 RID: 3847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F08 RID: 3848
		public const int PGAAILFLGCNFieldNumber = 2;

		// Token: 0x04000F09 RID: 3849
		private uint pGAAILFLGCN_;

		// Token: 0x04000F0A RID: 3850
		public const int TournFinishInfoFieldNumber = 11;

		// Token: 0x04000F0B RID: 3851
		private RogueTournFinishInfo tournFinishInfo_;
	}
}
