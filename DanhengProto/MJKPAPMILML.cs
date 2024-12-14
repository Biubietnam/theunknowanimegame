using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AEF RID: 2799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MJKPAPMILML : IMessage<MJKPAPMILML>, IMessage, IEquatable<MJKPAPMILML>, IDeepCloneable<MJKPAPMILML>, IBufferMessage
	{
		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06007BD6 RID: 31702 RVA: 0x00148068 File Offset: 0x00146268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MJKPAPMILML> Parser
		{
			get
			{
				return MJKPAPMILML._parser;
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x0014806F File Offset: 0x0014626F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MJKPAPMILMLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06007BD8 RID: 31704 RVA: 0x00148081 File Offset: 0x00146281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MJKPAPMILML.Descriptor;
			}
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x00148088 File Offset: 0x00146288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MJKPAPMILML()
		{
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x0014809B File Offset: 0x0014629B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MJKPAPMILML(MJKPAPMILML other) : this()
		{
			this.oONPFGPJBIP_ = other.oONPFGPJBIP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x001480C5 File Offset: 0x001462C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MJKPAPMILML Clone()
		{
			return new MJKPAPMILML(this);
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06007BDC RID: 31708 RVA: 0x001480CD File Offset: 0x001462CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OONPFGPJBIP
		{
			get
			{
				return this.oONPFGPJBIP_;
			}
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x001480D5 File Offset: 0x001462D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MJKPAPMILML);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x001480E3 File Offset: 0x001462E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MJKPAPMILML other)
		{
			return other != null && (other == this || (this.oONPFGPJBIP_.Equals(other.oONPFGPJBIP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x00148118 File Offset: 0x00146318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.oONPFGPJBIP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x0014814C File Offset: 0x0014634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x00148154 File Offset: 0x00146354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0014815D File Offset: 0x0014635D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oONPFGPJBIP_.WriteTo(ref output, MJKPAPMILML._repeated_oONPFGPJBIP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x00148184 File Offset: 0x00146384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.oONPFGPJBIP_.CalculateSize(MJKPAPMILML._repeated_oONPFGPJBIP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x001481BD File Offset: 0x001463BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MJKPAPMILML other)
		{
			if (other == null)
			{
				return;
			}
			this.oONPFGPJBIP_.Add(other.oONPFGPJBIP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x001481EB File Offset: 0x001463EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x001481F4 File Offset: 0x001463F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8984U && num != 8986U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.oONPFGPJBIP_.AddEntriesFrom(ref input, MJKPAPMILML._repeated_oONPFGPJBIP_codec);
				}
			}
		}

		// Token: 0x04002FA5 RID: 12197
		private static readonly MessageParser<MJKPAPMILML> _parser = new MessageParser<MJKPAPMILML>(() => new MJKPAPMILML());

		// Token: 0x04002FA6 RID: 12198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA7 RID: 12199
		public const int OONPFGPJBIPFieldNumber = 1123;

		// Token: 0x04002FA8 RID: 12200
		private static readonly FieldCodec<uint> _repeated_oONPFGPJBIP_codec = FieldCodec.ForUInt32(8986U);

		// Token: 0x04002FA9 RID: 12201
		private readonly RepeatedField<uint> oONPFGPJBIP_ = new RepeatedField<uint>();
	}
}
