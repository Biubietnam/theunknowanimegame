using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001375 RID: 4981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureGetDataScRsp : IMessage<TravelBrochureGetDataScRsp>, IMessage, IEquatable<TravelBrochureGetDataScRsp>, IDeepCloneable<TravelBrochureGetDataScRsp>, IBufferMessage
	{
		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600DE33 RID: 56883 RVA: 0x0024F7DE File Offset: 0x0024D9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureGetDataScRsp> Parser
		{
			get
			{
				return TravelBrochureGetDataScRsp._parser;
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600DE34 RID: 56884 RVA: 0x0024F7E5 File Offset: 0x0024D9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureGetDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x0024F7F7 File Offset: 0x0024D9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureGetDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x0024F7FE File Offset: 0x0024D9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataScRsp()
		{
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x0024F81C File Offset: 0x0024DA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataScRsp(TravelBrochureGetDataScRsp other) : this()
		{
			this.customValue_ = other.customValue_;
			this.gKABHDNABJG_ = other.gKABHDNABJG_.Clone();
			this.lDGFNJBEGOF_ = other.lDGFNJBEGOF_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x0024F87A File Offset: 0x0024DA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataScRsp Clone()
		{
			return new TravelBrochureGetDataScRsp(this);
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x0024F882 File Offset: 0x0024DA82
		// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x0024F88A File Offset: 0x0024DA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CustomValue
		{
			get
			{
				return this.customValue_;
			}
			set
			{
				this.customValue_ = value;
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600DE3B RID: 56891 RVA: 0x0024F893 File Offset: 0x0024DA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, KHKLKHNGDOG> GKABHDNABJG
		{
			get
			{
				return this.gKABHDNABJG_;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600DE3C RID: 56892 RVA: 0x0024F89B File Offset: 0x0024DA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> LDGFNJBEGOF
		{
			get
			{
				return this.lDGFNJBEGOF_;
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x0024F8A3 File Offset: 0x0024DAA3
		// (set) Token: 0x0600DE3E RID: 56894 RVA: 0x0024F8AB File Offset: 0x0024DAAB
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

		// Token: 0x0600DE3F RID: 56895 RVA: 0x0024F8B4 File Offset: 0x0024DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureGetDataScRsp);
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x0024F8C4 File Offset: 0x0024DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureGetDataScRsp other)
		{
			return other != null && (other == this || (this.CustomValue == other.CustomValue && this.GKABHDNABJG.Equals(other.GKABHDNABJG) && this.LDGFNJBEGOF.Equals(other.LDGFNJBEGOF) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x0024F938 File Offset: 0x0024DB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CustomValue != 0U)
			{
				num ^= this.CustomValue.GetHashCode();
			}
			num ^= this.GKABHDNABJG.GetHashCode();
			num ^= this.LDGFNJBEGOF.GetHashCode();
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

		// Token: 0x0600DE42 RID: 56898 RVA: 0x0024F9AC File Offset: 0x0024DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE43 RID: 56899 RVA: 0x0024F9B4 File Offset: 0x0024DBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE44 RID: 56900 RVA: 0x0024F9C0 File Offset: 0x0024DBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lDGFNJBEGOF_.WriteTo(ref output, TravelBrochureGetDataScRsp._map_lDGFNJBEGOF_codec);
			this.gKABHDNABJG_.WriteTo(ref output, TravelBrochureGetDataScRsp._map_gKABHDNABJG_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CustomValue != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CustomValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE45 RID: 56901 RVA: 0x0024FA3C File Offset: 0x0024DC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CustomValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CustomValue);
			}
			num += this.gKABHDNABJG_.CalculateSize(TravelBrochureGetDataScRsp._map_gKABHDNABJG_codec);
			num += this.lDGFNJBEGOF_.CalculateSize(TravelBrochureGetDataScRsp._map_lDGFNJBEGOF_codec);
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

		// Token: 0x0600DE46 RID: 56902 RVA: 0x0024FAB8 File Offset: 0x0024DCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureGetDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CustomValue != 0U)
			{
				this.CustomValue = other.CustomValue;
			}
			this.gKABHDNABJG_.MergeFrom(other.gKABHDNABJG_);
			this.lDGFNJBEGOF_.MergeFrom(other.lDGFNJBEGOF_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x0024FB2A File Offset: 0x0024DD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE48 RID: 56904 RVA: 0x0024FB34 File Offset: 0x0024DD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 42U)
					{
						this.lDGFNJBEGOF_.AddEntriesFrom(ref input, TravelBrochureGetDataScRsp._map_lDGFNJBEGOF_codec);
						continue;
					}
					if (num == 74U)
					{
						this.gKABHDNABJG_.AddEntriesFrom(ref input, TravelBrochureGetDataScRsp._map_gKABHDNABJG_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.CustomValue = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400585D RID: 22621
		private static readonly MessageParser<TravelBrochureGetDataScRsp> _parser = new MessageParser<TravelBrochureGetDataScRsp>(() => new TravelBrochureGetDataScRsp());

		// Token: 0x0400585E RID: 22622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400585F RID: 22623
		public const int CustomValueFieldNumber = 12;

		// Token: 0x04005860 RID: 22624
		private uint customValue_;

		// Token: 0x04005861 RID: 22625
		public const int GKABHDNABJGFieldNumber = 9;

		// Token: 0x04005862 RID: 22626
		private static readonly MapField<uint, KHKLKHNGDOG>.Codec _map_gKABHDNABJG_codec = new MapField<uint, KHKLKHNGDOG>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<KHKLKHNGDOG>(18U, KHKLKHNGDOG.Parser), 74U);

		// Token: 0x04005863 RID: 22627
		private readonly MapField<uint, KHKLKHNGDOG> gKABHDNABJG_ = new MapField<uint, KHKLKHNGDOG>();

		// Token: 0x04005864 RID: 22628
		public const int LDGFNJBEGOFFieldNumber = 5;

		// Token: 0x04005865 RID: 22629
		private static readonly MapField<uint, uint>.Codec _map_lDGFNJBEGOF_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 42U);

		// Token: 0x04005866 RID: 22630
		private readonly MapField<uint, uint> lDGFNJBEGOF_ = new MapField<uint, uint>();

		// Token: 0x04005867 RID: 22631
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005868 RID: 22632
		private uint retcode_;
	}
}
