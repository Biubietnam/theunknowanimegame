using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000563 RID: 1379
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishChapterScNotify : IMessage<FinishChapterScNotify>, IMessage, IEquatable<FinishChapterScNotify>, IDeepCloneable<FinishChapterScNotify>, IBufferMessage
	{
		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x000A857D File Offset: 0x000A677D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishChapterScNotify> Parser
		{
			get
			{
				return FinishChapterScNotify._parser;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x000A8584 File Offset: 0x000A6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishChapterScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x000A8596 File Offset: 0x000A6796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishChapterScNotify.Descriptor;
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x000A859D File Offset: 0x000A679D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChapterScNotify()
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x000A85A5 File Offset: 0x000A67A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChapterScNotify(FinishChapterScNotify other) : this()
		{
			this.lHGEBDIFNAP_ = ((other.lHGEBDIFNAP_ != null) ? other.lHGEBDIFNAP_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000A85DA File Offset: 0x000A67DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishChapterScNotify Clone()
		{
			return new FinishChapterScNotify(this);
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x000A85E2 File Offset: 0x000A67E2
		// (set) Token: 0x06003D81 RID: 15745 RVA: 0x000A85EA File Offset: 0x000A67EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticActivityData LHGEBDIFNAP
		{
			get
			{
				return this.lHGEBDIFNAP_;
			}
			set
			{
				this.lHGEBDIFNAP_ = value;
			}
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x000A85F3 File Offset: 0x000A67F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishChapterScNotify);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x000A8601 File Offset: 0x000A6801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishChapterScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LHGEBDIFNAP, other.LHGEBDIFNAP) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x000A8634 File Offset: 0x000A6834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lHGEBDIFNAP_ != null)
			{
				num ^= this.LHGEBDIFNAP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000A8670 File Offset: 0x000A6870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000A8678 File Offset: 0x000A6878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000A8681 File Offset: 0x000A6881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lHGEBDIFNAP_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.LHGEBDIFNAP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000A86B4 File Offset: 0x000A68B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lHGEBDIFNAP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHGEBDIFNAP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x000A86F4 File Offset: 0x000A68F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishChapterScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lHGEBDIFNAP_ != null)
			{
				if (this.lHGEBDIFNAP_ == null)
				{
					this.LHGEBDIFNAP = new FantasticActivityData();
				}
				this.LHGEBDIFNAP.MergeFrom(other.LHGEBDIFNAP);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x000A8748 File Offset: 0x000A6948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x000A8754 File Offset: 0x000A6954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lHGEBDIFNAP_ == null)
					{
						this.LHGEBDIFNAP = new FantasticActivityData();
					}
					input.ReadMessage(this.LHGEBDIFNAP);
				}
			}
		}

		// Token: 0x04001899 RID: 6297
		private static readonly MessageParser<FinishChapterScNotify> _parser = new MessageParser<FinishChapterScNotify>(() => new FinishChapterScNotify());

		// Token: 0x0400189A RID: 6298
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400189B RID: 6299
		public const int LHGEBDIFNAPFieldNumber = 15;

		// Token: 0x0400189C RID: 6300
		private FantasticActivityData lHGEBDIFNAP_;
	}
}
