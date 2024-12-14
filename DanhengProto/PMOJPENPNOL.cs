using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CEF RID: 3311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PMOJPENPNOL : IMessage<PMOJPENPNOL>, IMessage, IEquatable<PMOJPENPNOL>, IDeepCloneable<PMOJPENPNOL>, IBufferMessage
	{
		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x00189214 File Offset: 0x00187414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PMOJPENPNOL> Parser
		{
			get
			{
				return PMOJPENPNOL._parser;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060093DC RID: 37852 RVA: 0x0018921B File Offset: 0x0018741B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PMOJPENPNOLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x0018922D File Offset: 0x0018742D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PMOJPENPNOL.Descriptor;
			}
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x00189234 File Offset: 0x00187434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMOJPENPNOL()
		{
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x0018923C File Offset: 0x0018743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMOJPENPNOL(PMOJPENPNOL other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00189261 File Offset: 0x00187461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMOJPENPNOL Clone()
		{
			return new PMOJPENPNOL(this);
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x060093E1 RID: 37857 RVA: 0x00189269 File Offset: 0x00187469
		// (set) Token: 0x060093E2 RID: 37858 RVA: 0x00189271 File Offset: 0x00187471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x0018927A File Offset: 0x0018747A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PMOJPENPNOL);
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00189288 File Offset: 0x00187488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PMOJPENPNOL other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x001892B8 File Offset: 0x001874B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x001892F7 File Offset: 0x001874F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x001892FF File Offset: 0x001874FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00189308 File Offset: 0x00187508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x0018933C File Offset: 0x0018753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x0018937A File Offset: 0x0018757A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PMOJPENPNOL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x001893AB File Offset: 0x001875AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x001893B4 File Offset: 0x001875B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003946 RID: 14662
		private static readonly MessageParser<PMOJPENPNOL> _parser = new MessageParser<PMOJPENPNOL>(() => new PMOJPENPNOL());

		// Token: 0x04003947 RID: 14663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003948 RID: 14664
		public const int EventIdFieldNumber = 7;

		// Token: 0x04003949 RID: 14665
		private uint eventId_;
	}
}
