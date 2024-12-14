using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200010D RID: 269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BBDFLCJIEEJ : IMessage<BBDFLCJIEEJ>, IMessage, IEquatable<BBDFLCJIEEJ>, IDeepCloneable<BBDFLCJIEEJ>, IBufferMessage
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000246C5 File Offset: 0x000228C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BBDFLCJIEEJ> Parser
		{
			get
			{
				return BBDFLCJIEEJ._parser;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000246CC File Offset: 0x000228CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BBDFLCJIEEJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000246DE File Offset: 0x000228DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BBDFLCJIEEJ.Descriptor;
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000246E5 File Offset: 0x000228E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BBDFLCJIEEJ()
		{
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000246F8 File Offset: 0x000228F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BBDFLCJIEEJ(BBDFLCJIEEJ other) : this()
		{
			this.cKCJEHHACAL_ = other.cKCJEHHACAL_;
			this.lAOJOPBEIBC_ = other.lAOJOPBEIBC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002472E File Offset: 0x0002292E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BBDFLCJIEEJ Clone()
		{
			return new BBDFLCJIEEJ(this);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00024736 File Offset: 0x00022936
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0002473E File Offset: 0x0002293E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CKCJEHHACAL
		{
			get
			{
				return this.cKCJEHHACAL_;
			}
			set
			{
				this.cKCJEHHACAL_ = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00024747 File Offset: 0x00022947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NNCOHNDNMJJ> LAOJOPBEIBC
		{
			get
			{
				return this.lAOJOPBEIBC_;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002474F File Offset: 0x0002294F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BBDFLCJIEEJ);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00024760 File Offset: 0x00022960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BBDFLCJIEEJ other)
		{
			return other != null && (other == this || (this.CKCJEHHACAL == other.CKCJEHHACAL && this.lAOJOPBEIBC_.Equals(other.lAOJOPBEIBC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000247B0 File Offset: 0x000229B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CKCJEHHACAL != 0U)
			{
				num ^= this.CKCJEHHACAL.GetHashCode();
			}
			num ^= this.lAOJOPBEIBC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000247FD File Offset: 0x000229FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00024805 File Offset: 0x00022A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00024810 File Offset: 0x00022A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CKCJEHHACAL != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CKCJEHHACAL);
			}
			this.lAOJOPBEIBC_.WriteTo(ref output, BBDFLCJIEEJ._repeated_lAOJOPBEIBC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00024860 File Offset: 0x00022A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CKCJEHHACAL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CKCJEHHACAL);
			}
			num += this.lAOJOPBEIBC_.CalculateSize(BBDFLCJIEEJ._repeated_lAOJOPBEIBC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000248B4 File Offset: 0x00022AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BBDFLCJIEEJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CKCJEHHACAL != 0U)
			{
				this.CKCJEHHACAL = other.CKCJEHHACAL;
			}
			this.lAOJOPBEIBC_.Add(other.lAOJOPBEIBC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00024901 File Offset: 0x00022B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002490C File Offset: 0x00022B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lAOJOPBEIBC_.AddEntriesFrom(ref input, BBDFLCJIEEJ._repeated_lAOJOPBEIBC_codec);
					}
				}
				else
				{
					this.CKCJEHHACAL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000548 RID: 1352
		private static readonly MessageParser<BBDFLCJIEEJ> _parser = new MessageParser<BBDFLCJIEEJ>(() => new BBDFLCJIEEJ());

		// Token: 0x04000549 RID: 1353
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400054A RID: 1354
		public const int CKCJEHHACALFieldNumber = 1;

		// Token: 0x0400054B RID: 1355
		private uint cKCJEHHACAL_;

		// Token: 0x0400054C RID: 1356
		public const int LAOJOPBEIBCFieldNumber = 2;

		// Token: 0x0400054D RID: 1357
		private static readonly FieldCodec<NNCOHNDNMJJ> _repeated_lAOJOPBEIBC_codec = FieldCodec.ForMessage<NNCOHNDNMJJ>(18U, NNCOHNDNMJJ.Parser);

		// Token: 0x0400054E RID: 1358
		private readonly RepeatedField<NNCOHNDNMJJ> lAOJOPBEIBC_ = new RepeatedField<NNCOHNDNMJJ>();
	}
}
