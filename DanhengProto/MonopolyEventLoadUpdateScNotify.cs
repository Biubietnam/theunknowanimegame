using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B27 RID: 2855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyEventLoadUpdateScNotify : IMessage<MonopolyEventLoadUpdateScNotify>, IMessage, IEquatable<MonopolyEventLoadUpdateScNotify>, IDeepCloneable<MonopolyEventLoadUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x0014E15B File Offset: 0x0014C35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyEventLoadUpdateScNotify> Parser
		{
			get
			{
				return MonopolyEventLoadUpdateScNotify._parser;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0014E162 File Offset: 0x0014C362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyEventLoadUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x0014E174 File Offset: 0x0014C374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyEventLoadUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x0014E17B File Offset: 0x0014C37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventLoadUpdateScNotify()
		{
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x0014E199 File Offset: 0x0014C399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventLoadUpdateScNotify(MonopolyEventLoadUpdateScNotify other) : this()
		{
			this.dMHKBCBCLGF_ = other.dMHKBCBCLGF_.Clone();
			this.oIAJNADKJBP_ = other.oIAJNADKJBP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x0014E1D4 File Offset: 0x0014C3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventLoadUpdateScNotify Clone()
		{
			return new MonopolyEventLoadUpdateScNotify(this);
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06007E62 RID: 32354 RVA: 0x0014E1DC File Offset: 0x0014C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHAIJMPAJDL> DMHKBCBCLGF
		{
			get
			{
				return this.dMHKBCBCLGF_;
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0014E1E4 File Offset: 0x0014C3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DHAIJMPAJDL> OIAJNADKJBP
		{
			get
			{
				return this.oIAJNADKJBP_;
			}
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x0014E1EC File Offset: 0x0014C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyEventLoadUpdateScNotify);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x0014E1FC File Offset: 0x0014C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyEventLoadUpdateScNotify other)
		{
			return other != null && (other == this || (this.dMHKBCBCLGF_.Equals(other.dMHKBCBCLGF_) && this.oIAJNADKJBP_.Equals(other.oIAJNADKJBP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x0014E250 File Offset: 0x0014C450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dMHKBCBCLGF_.GetHashCode();
			num ^= this.oIAJNADKJBP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0014E292 File Offset: 0x0014C492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x0014E29A File Offset: 0x0014C49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x0014E2A3 File Offset: 0x0014C4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dMHKBCBCLGF_.WriteTo(ref output, MonopolyEventLoadUpdateScNotify._repeated_dMHKBCBCLGF_codec);
			this.oIAJNADKJBP_.WriteTo(ref output, MonopolyEventLoadUpdateScNotify._repeated_oIAJNADKJBP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x0014E2DC File Offset: 0x0014C4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dMHKBCBCLGF_.CalculateSize(MonopolyEventLoadUpdateScNotify._repeated_dMHKBCBCLGF_codec);
			num += this.oIAJNADKJBP_.CalculateSize(MonopolyEventLoadUpdateScNotify._repeated_oIAJNADKJBP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x0014E328 File Offset: 0x0014C528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyEventLoadUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dMHKBCBCLGF_.Add(other.dMHKBCBCLGF_);
			this.oIAJNADKJBP_.Add(other.oIAJNADKJBP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x0014E367 File Offset: 0x0014C567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x0014E370 File Offset: 0x0014C570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.oIAJNADKJBP_.AddEntriesFrom(ref input, MonopolyEventLoadUpdateScNotify._repeated_oIAJNADKJBP_codec);
					}
				}
				else
				{
					this.dMHKBCBCLGF_.AddEntriesFrom(ref input, MonopolyEventLoadUpdateScNotify._repeated_dMHKBCBCLGF_codec);
				}
			}
		}

		// Token: 0x04003073 RID: 12403
		private static readonly MessageParser<MonopolyEventLoadUpdateScNotify> _parser = new MessageParser<MonopolyEventLoadUpdateScNotify>(() => new MonopolyEventLoadUpdateScNotify());

		// Token: 0x04003074 RID: 12404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003075 RID: 12405
		public const int DMHKBCBCLGFFieldNumber = 2;

		// Token: 0x04003076 RID: 12406
		private static readonly FieldCodec<DHAIJMPAJDL> _repeated_dMHKBCBCLGF_codec = FieldCodec.ForMessage<DHAIJMPAJDL>(18U, DHAIJMPAJDL.Parser);

		// Token: 0x04003077 RID: 12407
		private readonly RepeatedField<DHAIJMPAJDL> dMHKBCBCLGF_ = new RepeatedField<DHAIJMPAJDL>();

		// Token: 0x04003078 RID: 12408
		public const int OIAJNADKJBPFieldNumber = 14;

		// Token: 0x04003079 RID: 12409
		private static readonly FieldCodec<DHAIJMPAJDL> _repeated_oIAJNADKJBP_codec = FieldCodec.ForMessage<DHAIJMPAJDL>(114U, DHAIJMPAJDL.Parser);

		// Token: 0x0400307A RID: 12410
		private readonly RepeatedField<DHAIJMPAJDL> oIAJNADKJBP_ = new RepeatedField<DHAIJMPAJDL>();
	}
}
