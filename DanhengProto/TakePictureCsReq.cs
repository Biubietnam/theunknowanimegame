using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001305 RID: 4869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePictureCsReq : IMessage<TakePictureCsReq>, IMessage, IEquatable<TakePictureCsReq>, IDeepCloneable<TakePictureCsReq>, IBufferMessage
	{
		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600D93C RID: 55612 RVA: 0x0024301E File Offset: 0x0024121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePictureCsReq> Parser
		{
			get
			{
				return TakePictureCsReq._parser;
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600D93D RID: 55613 RVA: 0x00243025 File Offset: 0x00241225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePictureCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600D93E RID: 55614 RVA: 0x00243037 File Offset: 0x00241237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePictureCsReq.Descriptor;
			}
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x0024303E File Offset: 0x0024123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureCsReq()
		{
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x00243046 File Offset: 0x00241246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureCsReq(TakePictureCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x0024305F File Offset: 0x0024125F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePictureCsReq Clone()
		{
			return new TakePictureCsReq(this);
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x00243067 File Offset: 0x00241267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePictureCsReq);
		}

		// Token: 0x0600D943 RID: 55619 RVA: 0x00243075 File Offset: 0x00241275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePictureCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x00243094 File Offset: 0x00241294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D945 RID: 55621 RVA: 0x002430BA File Offset: 0x002412BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x002430C2 File Offset: 0x002412C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x002430CB File Offset: 0x002412CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D948 RID: 55624 RVA: 0x002430E4 File Offset: 0x002412E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D949 RID: 55625 RVA: 0x0024310A File Offset: 0x0024130A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePictureCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D94A RID: 55626 RVA: 0x00243127 File Offset: 0x00241327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x00243130 File Offset: 0x00241330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400569C RID: 22172
		private static readonly MessageParser<TakePictureCsReq> _parser = new MessageParser<TakePictureCsReq>(() => new TakePictureCsReq());

		// Token: 0x0400569D RID: 22173
		private UnknownFieldSet _unknownFields;
	}
}
