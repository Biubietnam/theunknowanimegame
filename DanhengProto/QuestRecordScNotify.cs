using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D41 RID: 3393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestRecordScNotify : IMessage<QuestRecordScNotify>, IMessage, IEquatable<QuestRecordScNotify>, IDeepCloneable<QuestRecordScNotify>, IBufferMessage
	{
		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x060097AE RID: 38830 RVA: 0x001944FD File Offset: 0x001926FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestRecordScNotify> Parser
		{
			get
			{
				return QuestRecordScNotify._parser;
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x00194504 File Offset: 0x00192704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestRecordScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x060097B0 RID: 38832 RVA: 0x00194516 File Offset: 0x00192716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestRecordScNotify.Descriptor;
			}
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0019451D File Offset: 0x0019271D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecordScNotify()
		{
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x00194525 File Offset: 0x00192725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecordScNotify(QuestRecordScNotify other) : this()
		{
			this.oKIOMJAJGDF_ = ((other.oKIOMJAJGDF_ != null) ? other.oKIOMJAJGDF_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0019455A File Offset: 0x0019275A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecordScNotify Clone()
		{
			return new QuestRecordScNotify(this);
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x060097B4 RID: 38836 RVA: 0x00194562 File Offset: 0x00192762
		// (set) Token: 0x060097B5 RID: 38837 RVA: 0x0019456A File Offset: 0x0019276A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestRecord OKIOMJAJGDF
		{
			get
			{
				return this.oKIOMJAJGDF_;
			}
			set
			{
				this.oKIOMJAJGDF_ = value;
			}
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x00194573 File Offset: 0x00192773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestRecordScNotify);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x00194581 File Offset: 0x00192781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestRecordScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.OKIOMJAJGDF, other.OKIOMJAJGDF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x001945B4 File Offset: 0x001927B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oKIOMJAJGDF_ != null)
			{
				num ^= this.OKIOMJAJGDF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x001945F0 File Offset: 0x001927F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x001945F8 File Offset: 0x001927F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x00194601 File Offset: 0x00192801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oKIOMJAJGDF_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.OKIOMJAJGDF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x00194634 File Offset: 0x00192834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oKIOMJAJGDF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OKIOMJAJGDF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x00194674 File Offset: 0x00192874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestRecordScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oKIOMJAJGDF_ != null)
			{
				if (this.oKIOMJAJGDF_ == null)
				{
					this.OKIOMJAJGDF = new QuestRecord();
				}
				this.OKIOMJAJGDF.MergeFrom(other.OKIOMJAJGDF);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x001946C8 File Offset: 0x001928C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x001946D4 File Offset: 0x001928D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.oKIOMJAJGDF_ == null)
					{
						this.OKIOMJAJGDF = new QuestRecord();
					}
					input.ReadMessage(this.OKIOMJAJGDF);
				}
			}
		}

		// Token: 0x04003AFE RID: 15102
		private static readonly MessageParser<QuestRecordScNotify> _parser = new MessageParser<QuestRecordScNotify>(() => new QuestRecordScNotify());

		// Token: 0x04003AFF RID: 15103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B00 RID: 15104
		public const int OKIOMJAJGDFFieldNumber = 13;

		// Token: 0x04003B01 RID: 15105
		private QuestRecord oKIOMJAJGDF_;
	}
}
