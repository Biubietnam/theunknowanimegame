using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001307 RID: 4871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePictureScRsp : IMessage<TakePictureScRsp>, IMessage, IEquatable<TakePictureScRsp>, IDeepCloneable<TakePictureScRsp>, IBufferMessage
	{
		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600D94F RID: 55631 RVA: 0x002431E0 File Offset: 0x002413E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePictureScRsp> Parser
		{
			get
			{
				return TakePictureScRsp._parser;
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600D950 RID: 55632 RVA: 0x002431E7 File Offset: 0x002413E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePictureScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600D951 RID: 55633 RVA: 0x002431F9 File Offset: 0x002413F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePictureScRsp.Descriptor;
			}
		}

		// Token: 0x0600D952 RID: 55634 RVA: 0x00243200 File Offset: 0x00241400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureScRsp()
		{
		}

		// Token: 0x0600D953 RID: 55635 RVA: 0x00243208 File Offset: 0x00241408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureScRsp(TakePictureScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D954 RID: 55636 RVA: 0x0024322D File Offset: 0x0024142D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureScRsp Clone()
		{
			return new TakePictureScRsp(this);
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600D955 RID: 55637 RVA: 0x00243235 File Offset: 0x00241435
		// (set) Token: 0x0600D956 RID: 55638 RVA: 0x0024323D File Offset: 0x0024143D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600D957 RID: 55639 RVA: 0x00243246 File Offset: 0x00241446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePictureScRsp);
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x00243254 File Offset: 0x00241454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePictureScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x00243284 File Offset: 0x00241484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x002432C3 File Offset: 0x002414C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x002432CB File Offset: 0x002414CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D95C RID: 55644 RVA: 0x002432D4 File Offset: 0x002414D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D95D RID: 55645 RVA: 0x00243308 File Offset: 0x00241508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x00243346 File Offset: 0x00241546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePictureScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x00243377 File Offset: 0x00241577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x00243380 File Offset: 0x00241580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400569F RID: 22175
		private static readonly MessageParser<TakePictureScRsp> _parser = new MessageParser<TakePictureScRsp>(() => new TakePictureScRsp());

		// Token: 0x040056A0 RID: 22176
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056A1 RID: 22177
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040056A2 RID: 22178
		private uint retcode_;
	}
}
