using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A07 RID: 2567
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LEPMIKONNPH : IMessage<LEPMIKONNPH>, IMessage, IEquatable<LEPMIKONNPH>, IDeepCloneable<LEPMIKONNPH>, IBufferMessage
	{
		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x0012F179 File Offset: 0x0012D379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LEPMIKONNPH> Parser
		{
			get
			{
				return LEPMIKONNPH._parser;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x0012F180 File Offset: 0x0012D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LEPMIKONNPHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x0012F192 File Offset: 0x0012D392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LEPMIKONNPH.Descriptor;
			}
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x0012F199 File Offset: 0x0012D399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LEPMIKONNPH()
		{
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x0012F1AC File Offset: 0x0012D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LEPMIKONNPH(LEPMIKONNPH other) : this()
		{
			this.magicScepterInfoList_ = other.magicScepterInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x0012F1D6 File Offset: 0x0012D3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LEPMIKONNPH Clone()
		{
			return new LEPMIKONNPH(this);
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x0012F1DE File Offset: 0x0012D3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AMMDINMBHPF> MagicScepterInfoList
		{
			get
			{
				return this.magicScepterInfoList_;
			}
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x0012F1E6 File Offset: 0x0012D3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LEPMIKONNPH);
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x0012F1F4 File Offset: 0x0012D3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LEPMIKONNPH other)
		{
			return other != null && (other == this || (this.magicScepterInfoList_.Equals(other.magicScepterInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x0012F228 File Offset: 0x0012D428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.magicScepterInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x0012F25C File Offset: 0x0012D45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x0012F264 File Offset: 0x0012D464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x0012F26D File Offset: 0x0012D46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.magicScepterInfoList_.WriteTo(ref output, LEPMIKONNPH._repeated_magicScepterInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x0012F294 File Offset: 0x0012D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.magicScepterInfoList_.CalculateSize(LEPMIKONNPH._repeated_magicScepterInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x0012F2CD File Offset: 0x0012D4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LEPMIKONNPH other)
		{
			if (other == null)
			{
				return;
			}
			this.magicScepterInfoList_.Add(other.magicScepterInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x0012F2FB File Offset: 0x0012D4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x0012F304 File Offset: 0x0012D504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.magicScepterInfoList_.AddEntriesFrom(ref input, LEPMIKONNPH._repeated_magicScepterInfoList_codec);
				}
			}
		}

		// Token: 0x04002BC8 RID: 11208
		private static readonly MessageParser<LEPMIKONNPH> _parser = new MessageParser<LEPMIKONNPH>(() => new LEPMIKONNPH());

		// Token: 0x04002BC9 RID: 11209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BCA RID: 11210
		public const int MagicScepterInfoListFieldNumber = 10;

		// Token: 0x04002BCB RID: 11211
		private static readonly FieldCodec<AMMDINMBHPF> _repeated_magicScepterInfoList_codec = FieldCodec.ForMessage<AMMDINMBHPF>(82U, AMMDINMBHPF.Parser);

		// Token: 0x04002BCC RID: 11212
		private readonly RepeatedField<AMMDINMBHPF> magicScepterInfoList_ = new RepeatedField<AMMDINMBHPF>();
	}
}
