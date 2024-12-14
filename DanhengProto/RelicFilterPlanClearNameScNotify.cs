using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA5 RID: 3493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicFilterPlanClearNameScNotify : IMessage<RelicFilterPlanClearNameScNotify>, IMessage, IEquatable<RelicFilterPlanClearNameScNotify>, IDeepCloneable<RelicFilterPlanClearNameScNotify>, IBufferMessage
	{
		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x0019FACC File Offset: 0x0019DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicFilterPlanClearNameScNotify> Parser
		{
			get
			{
				return RelicFilterPlanClearNameScNotify._parser;
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06009C20 RID: 39968 RVA: 0x0019FAD3 File Offset: 0x0019DCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanClearNameScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x0019FAE5 File Offset: 0x0019DCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicFilterPlanClearNameScNotify.Descriptor;
			}
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x0019FAEC File Offset: 0x0019DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanClearNameScNotify()
		{
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x0019FAF4 File Offset: 0x0019DCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanClearNameScNotify(RelicFilterPlanClearNameScNotify other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x0019FB19 File Offset: 0x0019DD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanClearNameScNotify Clone()
		{
			return new RelicFilterPlanClearNameScNotify(this);
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06009C25 RID: 39973 RVA: 0x0019FB21 File Offset: 0x0019DD21
		// (set) Token: 0x06009C26 RID: 39974 RVA: 0x0019FB29 File Offset: 0x0019DD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x0019FB32 File Offset: 0x0019DD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicFilterPlanClearNameScNotify);
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x0019FB40 File Offset: 0x0019DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicFilterPlanClearNameScNotify other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x0019FB70 File Offset: 0x0019DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x0019FBAF File Offset: 0x0019DDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C2B RID: 39979 RVA: 0x0019FBB7 File Offset: 0x0019DDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x0019FBC0 File Offset: 0x0019DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x0019FBF4 File Offset: 0x0019DDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C2E RID: 39982 RVA: 0x0019FC32 File Offset: 0x0019DE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicFilterPlanClearNameScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x0019FC63 File Offset: 0x0019DE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x0019FC6C File Offset: 0x0019DE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003C9F RID: 15519
		private static readonly MessageParser<RelicFilterPlanClearNameScNotify> _parser = new MessageParser<RelicFilterPlanClearNameScNotify>(() => new RelicFilterPlanClearNameScNotify());

		// Token: 0x04003CA0 RID: 15520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA1 RID: 15521
		public const int MaxTimesFieldNumber = 10;

		// Token: 0x04003CA2 RID: 15522
		private uint maxTimes_;
	}
}
