using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000341 RID: 833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CurTrialActivityScNotify : IMessage<CurTrialActivityScNotify>, IMessage, IEquatable<CurTrialActivityScNotify>, IDeepCloneable<CurTrialActivityScNotify>, IBufferMessage
	{
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0006929F File Offset: 0x0006749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CurTrialActivityScNotify> Parser
		{
			get
			{
				return CurTrialActivityScNotify._parser;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000692A6 File Offset: 0x000674A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CurTrialActivityScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000692B8 File Offset: 0x000674B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurTrialActivityScNotify.Descriptor;
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000692BF File Offset: 0x000674BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurTrialActivityScNotify()
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000692C7 File Offset: 0x000674C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurTrialActivityScNotify(CurTrialActivityScNotify other) : this()
		{
			this.activityStageId_ = other.activityStageId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000692F8 File Offset: 0x000674F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurTrialActivityScNotify Clone()
		{
			return new CurTrialActivityScNotify(this);
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00069300 File Offset: 0x00067500
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00069308 File Offset: 0x00067508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ActivityStageId
		{
			get
			{
				return this.activityStageId_;
			}
			set
			{
				this.activityStageId_ = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00069311 File Offset: 0x00067511
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00069319 File Offset: 0x00067519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialActivityStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00069322 File Offset: 0x00067522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurTrialActivityScNotify);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00069330 File Offset: 0x00067530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CurTrialActivityScNotify other)
		{
			return other != null && (other == this || (this.ActivityStageId == other.ActivityStageId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00069370 File Offset: 0x00067570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityStageId != 0U)
			{
				num ^= this.ActivityStageId.GetHashCode();
			}
			if (this.Status != TrialActivityStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000693CE File Offset: 0x000675CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000693D6 File Offset: 0x000675D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000693E0 File Offset: 0x000675E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != TrialActivityStatus.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			if (this.ActivityStageId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ActivityStageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00069438 File Offset: 0x00067638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityStageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ActivityStageId);
			}
			if (this.Status != TrialActivityStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00069490 File Offset: 0x00067690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CurTrialActivityScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityStageId != 0U)
			{
				this.ActivityStageId = other.ActivityStageId;
			}
			if (other.Status != TrialActivityStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000694E0 File Offset: 0x000676E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000694EC File Offset: 0x000676EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityStageId = input.ReadUInt32();
					}
				}
				else
				{
					this.Status = (TrialActivityStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000F2D RID: 3885
		private static readonly MessageParser<CurTrialActivityScNotify> _parser = new MessageParser<CurTrialActivityScNotify>(() => new CurTrialActivityScNotify());

		// Token: 0x04000F2E RID: 3886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F2F RID: 3887
		public const int ActivityStageIdFieldNumber = 7;

		// Token: 0x04000F30 RID: 3888
		private uint activityStageId_;

		// Token: 0x04000F31 RID: 3889
		public const int StatusFieldNumber = 1;

		// Token: 0x04000F32 RID: 3890
		private TrialActivityStatus status_;
	}
}
