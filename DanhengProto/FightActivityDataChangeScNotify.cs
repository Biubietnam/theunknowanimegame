using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000523 RID: 1315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightActivityDataChangeScNotify : IMessage<FightActivityDataChangeScNotify>, IMessage, IEquatable<FightActivityDataChangeScNotify>, IDeepCloneable<FightActivityDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x000A1898 File Offset: 0x0009FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightActivityDataChangeScNotify> Parser
		{
			get
			{
				return FightActivityDataChangeScNotify._parser;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x000A189F File Offset: 0x0009FA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x000A18B1 File Offset: 0x0009FAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightActivityDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000A18B8 File Offset: 0x0009FAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityDataChangeScNotify()
		{
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x000A18D6 File Offset: 0x0009FAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityDataChangeScNotify(FightActivityDataChangeScNotify other) : this()
		{
			this.dPFKPKDKONP_ = other.dPFKPKDKONP_.Clone();
			this.jDNHCNHAMML_ = other.jDNHCNHAMML_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x000A1911 File Offset: 0x0009FB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightActivityDataChangeScNotify Clone()
		{
			return new FightActivityDataChangeScNotify(this);
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x000A1919 File Offset: 0x0009FB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightActivityGroup> DPFKPKDKONP
		{
			get
			{
				return this.dPFKPKDKONP_;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x000A1921 File Offset: 0x0009FB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> JDNHCNHAMML
		{
			get
			{
				return this.jDNHCNHAMML_;
			}
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x000A1929 File Offset: 0x0009FB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightActivityDataChangeScNotify);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x000A1938 File Offset: 0x0009FB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightActivityDataChangeScNotify other)
		{
			return other != null && (other == this || (this.dPFKPKDKONP_.Equals(other.dPFKPKDKONP_) && this.JDNHCNHAMML.Equals(other.JDNHCNHAMML) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x000A198C File Offset: 0x0009FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dPFKPKDKONP_.GetHashCode();
			num ^= this.JDNHCNHAMML.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x000A19CE File Offset: 0x0009FBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x000A19D6 File Offset: 0x0009FBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x000A19DF File Offset: 0x0009FBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dPFKPKDKONP_.WriteTo(ref output, FightActivityDataChangeScNotify._repeated_dPFKPKDKONP_codec);
			this.jDNHCNHAMML_.WriteTo(ref output, FightActivityDataChangeScNotify._map_jDNHCNHAMML_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x000A1A18 File Offset: 0x0009FC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dPFKPKDKONP_.CalculateSize(FightActivityDataChangeScNotify._repeated_dPFKPKDKONP_codec);
			num += this.jDNHCNHAMML_.CalculateSize(FightActivityDataChangeScNotify._map_jDNHCNHAMML_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x000A1A64 File Offset: 0x0009FC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightActivityDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dPFKPKDKONP_.Add(other.dPFKPKDKONP_);
			this.jDNHCNHAMML_.MergeFrom(other.jDNHCNHAMML_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x000A1AA3 File Offset: 0x0009FCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x000A1AAC File Offset: 0x0009FCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.jDNHCNHAMML_.AddEntriesFrom(ref input, FightActivityDataChangeScNotify._map_jDNHCNHAMML_codec);
					}
				}
				else
				{
					this.dPFKPKDKONP_.AddEntriesFrom(ref input, FightActivityDataChangeScNotify._repeated_dPFKPKDKONP_codec);
				}
			}
		}

		// Token: 0x0400179C RID: 6044
		private static readonly MessageParser<FightActivityDataChangeScNotify> _parser = new MessageParser<FightActivityDataChangeScNotify>(() => new FightActivityDataChangeScNotify());

		// Token: 0x0400179D RID: 6045
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400179E RID: 6046
		public const int DPFKPKDKONPFieldNumber = 1;

		// Token: 0x0400179F RID: 6047
		private static readonly FieldCodec<FightActivityGroup> _repeated_dPFKPKDKONP_codec = FieldCodec.ForMessage<FightActivityGroup>(10U, FightActivityGroup.Parser);

		// Token: 0x040017A0 RID: 6048
		private readonly RepeatedField<FightActivityGroup> dPFKPKDKONP_ = new RepeatedField<FightActivityGroup>();

		// Token: 0x040017A1 RID: 6049
		public const int JDNHCNHAMMLFieldNumber = 13;

		// Token: 0x040017A2 RID: 6050
		private static readonly MapField<uint, uint>.Codec _map_jDNHCNHAMML_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 106U);

		// Token: 0x040017A3 RID: 6051
		private readonly MapField<uint, uint> jDNHCNHAMML_ = new MapField<uint, uint>();
	}
}
