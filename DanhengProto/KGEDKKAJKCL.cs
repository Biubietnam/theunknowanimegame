using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200099D RID: 2461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KGEDKKAJKCL : IMessage<KGEDKKAJKCL>, IMessage, IEquatable<KGEDKKAJKCL>, IDeepCloneable<KGEDKKAJKCL>, IBufferMessage
	{
		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06006E05 RID: 28165 RVA: 0x00126039 File Offset: 0x00124239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KGEDKKAJKCL> Parser
		{
			get
			{
				return KGEDKKAJKCL._parser;
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x00126040 File Offset: 0x00124240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KGEDKKAJKCLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x00126052 File Offset: 0x00124252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KGEDKKAJKCL.Descriptor;
			}
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x00126059 File Offset: 0x00124259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGEDKKAJKCL()
		{
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00126077 File Offset: 0x00124277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGEDKKAJKCL(KGEDKKAJKCL other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x001260B2 File Offset: 0x001242B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGEDKKAJKCL Clone()
		{
			return new KGEDKKAJKCL(this);
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x001260BA File Offset: 0x001242BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ALLFKPIPPDH> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06006E0C RID: 28172 RVA: 0x001260C2 File Offset: 0x001242C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x001260CA File Offset: 0x001242CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KGEDKKAJKCL);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x001260D8 File Offset: 0x001242D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KGEDKKAJKCL other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x0012612C File Offset: 0x0012432C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0012616E File Offset: 0x0012436E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00126176 File Offset: 0x00124376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x0012617F File Offset: 0x0012437F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, KGEDKKAJKCL._repeated_buffList_codec);
			this.avatarList_.WriteTo(ref output, KGEDKKAJKCL._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x001261B8 File Offset: 0x001243B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(KGEDKKAJKCL._repeated_avatarList_codec);
			num += this.buffList_.CalculateSize(KGEDKKAJKCL._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00126204 File Offset: 0x00124404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KGEDKKAJKCL other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00126243 File Offset: 0x00124443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x0012624C File Offset: 0x0012444C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.avatarList_.AddEntriesFrom(ref input, KGEDKKAJKCL._repeated_avatarList_codec);
					}
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, KGEDKKAJKCL._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x04002A42 RID: 10818
		private static readonly MessageParser<KGEDKKAJKCL> _parser = new MessageParser<KGEDKKAJKCL>(() => new KGEDKKAJKCL());

		// Token: 0x04002A43 RID: 10819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A44 RID: 10820
		public const int AvatarListFieldNumber = 10;

		// Token: 0x04002A45 RID: 10821
		private static readonly FieldCodec<ALLFKPIPPDH> _repeated_avatarList_codec = FieldCodec.ForMessage<ALLFKPIPPDH>(82U, ALLFKPIPPDH.Parser);

		// Token: 0x04002A46 RID: 10822
		private readonly RepeatedField<ALLFKPIPPDH> avatarList_ = new RepeatedField<ALLFKPIPPDH>();

		// Token: 0x04002A47 RID: 10823
		public const int BuffListFieldNumber = 9;

		// Token: 0x04002A48 RID: 10824
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002A49 RID: 10825
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();
	}
}
