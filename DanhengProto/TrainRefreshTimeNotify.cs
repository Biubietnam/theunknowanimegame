using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200135F RID: 4959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrainRefreshTimeNotify : IMessage<TrainRefreshTimeNotify>, IMessage, IEquatable<TrainRefreshTimeNotify>, IDeepCloneable<TrainRefreshTimeNotify>, IBufferMessage
	{
		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x0024D128 File Offset: 0x0024B328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrainRefreshTimeNotify> Parser
		{
			get
			{
				return TrainRefreshTimeNotify._parser;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x0024D12F File Offset: 0x0024B32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrainRefreshTimeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600DD45 RID: 56645 RVA: 0x0024D141 File Offset: 0x0024B341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrainRefreshTimeNotify.Descriptor;
			}
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x0024D148 File Offset: 0x0024B348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainRefreshTimeNotify()
		{
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x0024D150 File Offset: 0x0024B350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainRefreshTimeNotify(TrainRefreshTimeNotify other) : this()
		{
			this.dCEGMLENIMF_ = other.dCEGMLENIMF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD48 RID: 56648 RVA: 0x0024D175 File Offset: 0x0024B375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainRefreshTimeNotify Clone()
		{
			return new TrainRefreshTimeNotify(this);
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x0024D17D File Offset: 0x0024B37D
		// (set) Token: 0x0600DD4A RID: 56650 RVA: 0x0024D185 File Offset: 0x0024B385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong DCEGMLENIMF
		{
			get
			{
				return this.dCEGMLENIMF_;
			}
			set
			{
				this.dCEGMLENIMF_ = value;
			}
		}

		// Token: 0x0600DD4B RID: 56651 RVA: 0x0024D18E File Offset: 0x0024B38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrainRefreshTimeNotify);
		}

		// Token: 0x0600DD4C RID: 56652 RVA: 0x0024D19C File Offset: 0x0024B39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrainRefreshTimeNotify other)
		{
			return other != null && (other == this || (this.DCEGMLENIMF == other.DCEGMLENIMF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD4D RID: 56653 RVA: 0x0024D1CC File Offset: 0x0024B3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DCEGMLENIMF != 0UL)
			{
				num ^= this.DCEGMLENIMF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x0024D20B File Offset: 0x0024B40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x0024D213 File Offset: 0x0024B413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x0024D21C File Offset: 0x0024B41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DCEGMLENIMF != 0UL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.DCEGMLENIMF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x0024D250 File Offset: 0x0024B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DCEGMLENIMF != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.DCEGMLENIMF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x0024D28E File Offset: 0x0024B48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrainRefreshTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DCEGMLENIMF != 0UL)
			{
				this.DCEGMLENIMF = other.DCEGMLENIMF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x0024D2BF File Offset: 0x0024B4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x0024D2C8 File Offset: 0x0024B4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DCEGMLENIMF = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04005805 RID: 22533
		private static readonly MessageParser<TrainRefreshTimeNotify> _parser = new MessageParser<TrainRefreshTimeNotify>(() => new TrainRefreshTimeNotify());

		// Token: 0x04005806 RID: 22534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005807 RID: 22535
		public const int DCEGMLENIMFFieldNumber = 13;

		// Token: 0x04005808 RID: 22536
		private ulong dCEGMLENIMF_;
	}
}
