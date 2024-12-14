using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200035F RID: 863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DCMFOFEBFAK : IMessage<DCMFOFEBFAK>, IMessage, IEquatable<DCMFOFEBFAK>, IDeepCloneable<DCMFOFEBFAK>, IBufferMessage
	{
		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x0006C01E File Offset: 0x0006A21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DCMFOFEBFAK> Parser
		{
			get
			{
				return DCMFOFEBFAK._parser;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0006C025 File Offset: 0x0006A225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DCMFOFEBFAKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x0006C037 File Offset: 0x0006A237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DCMFOFEBFAK.Descriptor;
			}
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x0006C03E File Offset: 0x0006A23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DCMFOFEBFAK()
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0006C046 File Offset: 0x0006A246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DCMFOFEBFAK(DCMFOFEBFAK other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0006C05F File Offset: 0x0006A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DCMFOFEBFAK Clone()
		{
			return new DCMFOFEBFAK(this);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x0006C067 File Offset: 0x0006A267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DCMFOFEBFAK);
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x0006C075 File Offset: 0x0006A275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DCMFOFEBFAK other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x0006C094 File Offset: 0x0006A294
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

		// Token: 0x06002688 RID: 9864 RVA: 0x0006C0BA File Offset: 0x0006A2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x0006C0C2 File Offset: 0x0006A2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x0006C0CB File Offset: 0x0006A2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
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

		// Token: 0x0600268C RID: 9868 RVA: 0x0006C10A File Offset: 0x0006A30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DCMFOFEBFAK other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0006C127 File Offset: 0x0006A327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0006C130 File Offset: 0x0006A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F97 RID: 3991
		private static readonly MessageParser<DCMFOFEBFAK> _parser = new MessageParser<DCMFOFEBFAK>(() => new DCMFOFEBFAK());

		// Token: 0x04000F98 RID: 3992
		private UnknownFieldSet _unknownFields;
	}
}
