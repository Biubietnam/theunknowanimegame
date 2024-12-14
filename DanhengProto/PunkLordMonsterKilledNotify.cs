using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2F RID: 3375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordMonsterKilledNotify : IMessage<PunkLordMonsterKilledNotify>, IMessage, IEquatable<PunkLordMonsterKilledNotify>, IDeepCloneable<PunkLordMonsterKilledNotify>, IBufferMessage
	{
		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x060096BF RID: 38591 RVA: 0x001912A7 File Offset: 0x0018F4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordMonsterKilledNotify> Parser
		{
			get
			{
				return PunkLordMonsterKilledNotify._parser;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x001912AE File Offset: 0x0018F4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterKilledNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x060096C1 RID: 38593 RVA: 0x001912C0 File Offset: 0x0018F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordMonsterKilledNotify.Descriptor;
			}
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x001912C7 File Offset: 0x0018F4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKilledNotify()
		{
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x001912CF File Offset: 0x0018F4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKilledNotify(PunkLordMonsterKilledNotify other) : this()
		{
			this.hEPIFDFCGHA_ = ((other.hEPIFDFCGHA_ != null) ? other.hEPIFDFCGHA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00191304 File Offset: 0x0018F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterKilledNotify Clone()
		{
			return new PunkLordMonsterKilledNotify(this);
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x060096C5 RID: 38597 RVA: 0x0019130C File Offset: 0x0018F50C
		// (set) Token: 0x060096C6 RID: 38598 RVA: 0x00191314 File Offset: 0x0018F514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KilledPunkLordMonsterInfo HEPIFDFCGHA
		{
			get
			{
				return this.hEPIFDFCGHA_;
			}
			set
			{
				this.hEPIFDFCGHA_ = value;
			}
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0019131D File Offset: 0x0018F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordMonsterKilledNotify);
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x0019132B File Offset: 0x0018F52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordMonsterKilledNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HEPIFDFCGHA, other.HEPIFDFCGHA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00191360 File Offset: 0x0018F560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hEPIFDFCGHA_ != null)
			{
				num ^= this.HEPIFDFCGHA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x0019139C File Offset: 0x0018F59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x001913A4 File Offset: 0x0018F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x001913AD File Offset: 0x0018F5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hEPIFDFCGHA_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.HEPIFDFCGHA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x001913E0 File Offset: 0x0018F5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hEPIFDFCGHA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HEPIFDFCGHA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x00191420 File Offset: 0x0018F620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordMonsterKilledNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hEPIFDFCGHA_ != null)
			{
				if (this.hEPIFDFCGHA_ == null)
				{
					this.HEPIFDFCGHA = new KilledPunkLordMonsterInfo();
				}
				this.HEPIFDFCGHA.MergeFrom(other.HEPIFDFCGHA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x00191474 File Offset: 0x0018F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x00191480 File Offset: 0x0018F680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.hEPIFDFCGHA_ == null)
					{
						this.HEPIFDFCGHA = new KilledPunkLordMonsterInfo();
					}
					input.ReadMessage(this.HEPIFDFCGHA);
				}
			}
		}

		// Token: 0x04003A82 RID: 14978
		private static readonly MessageParser<PunkLordMonsterKilledNotify> _parser = new MessageParser<PunkLordMonsterKilledNotify>(() => new PunkLordMonsterKilledNotify());

		// Token: 0x04003A83 RID: 14979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A84 RID: 14980
		public const int HEPIFDFCGHAFieldNumber = 4;

		// Token: 0x04003A85 RID: 14981
		private KilledPunkLordMonsterInfo hEPIFDFCGHA_;
	}
}
