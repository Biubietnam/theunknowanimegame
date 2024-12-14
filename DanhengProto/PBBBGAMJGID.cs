using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C81 RID: 3201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PBBBGAMJGID : IMessage<PBBBGAMJGID>, IMessage, IEquatable<PBBBGAMJGID>, IDeepCloneable<PBBBGAMJGID>, IBufferMessage
	{
		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00177CE4 File Offset: 0x00175EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PBBBGAMJGID> Parser
		{
			get
			{
				return PBBBGAMJGID._parser;
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x06008E42 RID: 36418 RVA: 0x00177CEB File Offset: 0x00175EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PBBBGAMJGIDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00177CFD File Offset: 0x00175EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PBBBGAMJGID.Descriptor;
			}
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x00177D04 File Offset: 0x00175F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBBBGAMJGID()
		{
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x00177D17 File Offset: 0x00175F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBBBGAMJGID(PBBBGAMJGID other) : this()
		{
			this.cOCHKIAJGHG_ = other.cOCHKIAJGHG_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x00177D4D File Offset: 0x00175F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBBBGAMJGID Clone()
		{
			return new PBBBGAMJGID(this);
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x00177D55 File Offset: 0x00175F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> COCHKIAJGHG
		{
			get
			{
				return this.cOCHKIAJGHG_;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00177D5D File Offset: 0x00175F5D
		// (set) Token: 0x06008E49 RID: 36425 RVA: 0x00177D65 File Offset: 0x00175F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x00177D6E File Offset: 0x00175F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PBBBGAMJGID);
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x00177D7C File Offset: 0x00175F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PBBBGAMJGID other)
		{
			return other != null && (other == this || (this.cOCHKIAJGHG_.Equals(other.cOCHKIAJGHG_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x00177DCC File Offset: 0x00175FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cOCHKIAJGHG_.GetHashCode();
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x00177E19 File Offset: 0x00176019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00177E21 File Offset: 0x00176021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x00177E2C File Offset: 0x0017602C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cOCHKIAJGHG_.WriteTo(ref output, PBBBGAMJGID._repeated_cOCHKIAJGHG_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x00177E7C File Offset: 0x0017607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cOCHKIAJGHG_.CalculateSize(PBBBGAMJGID._repeated_cOCHKIAJGHG_codec);
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x00177ED0 File Offset: 0x001760D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PBBBGAMJGID other)
		{
			if (other == null)
			{
				return;
			}
			this.cOCHKIAJGHG_.Add(other.cOCHKIAJGHG_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00177F1D File Offset: 0x0017611D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00177F28 File Offset: 0x00176128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U && num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.cOCHKIAJGHG_.AddEntriesFrom(ref input, PBBBGAMJGID._repeated_cOCHKIAJGHG_codec);
				}
			}
		}

		// Token: 0x04003699 RID: 13977
		private static readonly MessageParser<PBBBGAMJGID> _parser = new MessageParser<PBBBGAMJGID>(() => new PBBBGAMJGID());

		// Token: 0x0400369A RID: 13978
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400369B RID: 13979
		public const int COCHKIAJGHGFieldNumber = 11;

		// Token: 0x0400369C RID: 13980
		private static readonly FieldCodec<uint> _repeated_cOCHKIAJGHG_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x0400369D RID: 13981
		private readonly RepeatedField<uint> cOCHKIAJGHG_ = new RepeatedField<uint>();

		// Token: 0x0400369E RID: 13982
		public const int SelectHintIdFieldNumber = 15;

		// Token: 0x0400369F RID: 13983
		private uint selectHintId_;
	}
}
