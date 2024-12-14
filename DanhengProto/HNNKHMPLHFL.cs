using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000901 RID: 2305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HNNKHMPLHFL : IMessage<HNNKHMPLHFL>, IMessage, IEquatable<HNNKHMPLHFL>, IDeepCloneable<HNNKHMPLHFL>, IBufferMessage
	{
		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x00112B32 File Offset: 0x00110D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HNNKHMPLHFL> Parser
		{
			get
			{
				return HNNKHMPLHFL._parser;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x00112B39 File Offset: 0x00110D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HNNKHMPLHFLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x00112B4B File Offset: 0x00110D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HNNKHMPLHFL.Descriptor;
			}
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00112B52 File Offset: 0x00110D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNNKHMPLHFL()
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00112B5A File Offset: 0x00110D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNNKHMPLHFL(HNNKHMPLHFL other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x00112B73 File Offset: 0x00110D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HNNKHMPLHFL Clone()
		{
			return new HNNKHMPLHFL(this);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00112B7B File Offset: 0x00110D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HNNKHMPLHFL);
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00112B89 File Offset: 0x00110D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HNNKHMPLHFL other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00112BA8 File Offset: 0x00110DA8
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

		// Token: 0x060066DE RID: 26334 RVA: 0x00112BCE File Offset: 0x00110DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00112BD6 File Offset: 0x00110DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00112BDF File Offset: 0x00110DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x00112BF8 File Offset: 0x00110DF8
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

		// Token: 0x060066E2 RID: 26338 RVA: 0x00112C1E File Offset: 0x00110E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HNNKHMPLHFL other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x00112C3B File Offset: 0x00110E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00112C44 File Offset: 0x00110E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002780 RID: 10112
		private static readonly MessageParser<HNNKHMPLHFL> _parser = new MessageParser<HNNKHMPLHFL>(() => new HNNKHMPLHFL());

		// Token: 0x04002781 RID: 10113
		private UnknownFieldSet _unknownFields;
	}
}
