using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000085 RID: 133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyFundsScNotify : IMessage<AlleyFundsScNotify>, IMessage, IEquatable<AlleyFundsScNotify>, IDeepCloneable<AlleyFundsScNotify>, IBufferMessage
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x000102FC File Offset: 0x0000E4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyFundsScNotify> Parser
		{
			get
			{
				return AlleyFundsScNotify._parser;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00010303 File Offset: 0x0000E503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyFundsScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00010315 File Offset: 0x0000E515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyFundsScNotify.Descriptor;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001031C File Offset: 0x0000E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyFundsScNotify()
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00010324 File Offset: 0x0000E524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyFundsScNotify(AlleyFundsScNotify other) : this()
		{
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00010349 File Offset: 0x0000E549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyFundsScNotify Clone()
		{
			return new AlleyFundsScNotify(this);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00010351 File Offset: 0x0000E551
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00010359 File Offset: 0x0000E559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMIDJEHMHMP
		{
			get
			{
				return this.mMIDJEHMHMP_;
			}
			set
			{
				this.mMIDJEHMHMP_ = value;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00010362 File Offset: 0x0000E562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyFundsScNotify);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00010370 File Offset: 0x0000E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyFundsScNotify other)
		{
			return other != null && (other == this || (this.MMIDJEHMHMP == other.MMIDJEHMHMP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000103A0 File Offset: 0x0000E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000103DF File Offset: 0x0000E5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000103E7 File Offset: 0x0000E5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000103F0 File Offset: 0x0000E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00010424 File Offset: 0x0000E624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00010462 File Offset: 0x0000E662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyFundsScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00010493 File Offset: 0x0000E693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001049C File Offset: 0x0000E69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MMIDJEHMHMP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000217 RID: 535
		private static readonly MessageParser<AlleyFundsScNotify> _parser = new MessageParser<AlleyFundsScNotify>(() => new AlleyFundsScNotify());

		// Token: 0x04000218 RID: 536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000219 RID: 537
		public const int MMIDJEHMHMPFieldNumber = 15;

		// Token: 0x0400021A RID: 538
		private uint mMIDJEHMHMP_;
	}
}
