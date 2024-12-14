using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F5 RID: 2293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HKIPEMDOMMD : IMessage<HKIPEMDOMMD>, IMessage, IEquatable<HKIPEMDOMMD>, IDeepCloneable<HKIPEMDOMMD>, IBufferMessage
	{
		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x001117A2 File Offset: 0x0010F9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HKIPEMDOMMD> Parser
		{
			get
			{
				return HKIPEMDOMMD._parser;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x0600664E RID: 26190 RVA: 0x001117A9 File Offset: 0x0010F9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HKIPEMDOMMDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x001117BB File Offset: 0x0010F9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HKIPEMDOMMD.Descriptor;
			}
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x001117C2 File Offset: 0x0010F9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKIPEMDOMMD()
		{
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x001117CA File Offset: 0x0010F9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKIPEMDOMMD(HKIPEMDOMMD other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x001117E3 File Offset: 0x0010F9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKIPEMDOMMD Clone()
		{
			return new HKIPEMDOMMD(this);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x001117EB File Offset: 0x0010F9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HKIPEMDOMMD);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001117F9 File Offset: 0x0010F9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HKIPEMDOMMD other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x00111818 File Offset: 0x0010FA18
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

		// Token: 0x06006656 RID: 26198 RVA: 0x0011183E File Offset: 0x0010FA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x00111846 File Offset: 0x0010FA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x0011184F File Offset: 0x0010FA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x00111868 File Offset: 0x0010FA68
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

		// Token: 0x0600665A RID: 26202 RVA: 0x0011188E File Offset: 0x0010FA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HKIPEMDOMMD other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x001118AB File Offset: 0x0010FAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x001118B4 File Offset: 0x0010FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002758 RID: 10072
		private static readonly MessageParser<HKIPEMDOMMD> _parser = new MessageParser<HKIPEMDOMMD>(() => new HKIPEMDOMMD());

		// Token: 0x04002759 RID: 10073
		private UnknownFieldSet _unknownFields;
	}
}
