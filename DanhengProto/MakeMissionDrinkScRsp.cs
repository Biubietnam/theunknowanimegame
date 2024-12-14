using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A7D RID: 2685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MakeMissionDrinkScRsp : IMessage<MakeMissionDrinkScRsp>, IMessage, IEquatable<MakeMissionDrinkScRsp>, IDeepCloneable<MakeMissionDrinkScRsp>, IBufferMessage
	{
		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06007700 RID: 30464 RVA: 0x0013BC5B File Offset: 0x00139E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MakeMissionDrinkScRsp> Parser
		{
			get
			{
				return MakeMissionDrinkScRsp._parser;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x0013BC62 File Offset: 0x00139E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MakeMissionDrinkScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06007702 RID: 30466 RVA: 0x0013BC74 File Offset: 0x00139E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MakeMissionDrinkScRsp.Descriptor;
			}
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x0013BC7B File Offset: 0x00139E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkScRsp()
		{
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x0013BC84 File Offset: 0x00139E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkScRsp(MakeMissionDrinkScRsp other) : this()
		{
			this.isSucc_ = other.isSucc_;
			this.isSave_ = other.isSave_;
			this.customDrink_ = ((other.customDrink_ != null) ? other.customDrink_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x0013BCE8 File Offset: 0x00139EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkScRsp Clone()
		{
			return new MakeMissionDrinkScRsp(this);
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06007706 RID: 30470 RVA: 0x0013BCF0 File Offset: 0x00139EF0
		// (set) Token: 0x06007707 RID: 30471 RVA: 0x0013BCF8 File Offset: 0x00139EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSucc
		{
			get
			{
				return this.isSucc_;
			}
			set
			{
				this.isSucc_ = value;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06007708 RID: 30472 RVA: 0x0013BD01 File Offset: 0x00139F01
		// (set) Token: 0x06007709 RID: 30473 RVA: 0x0013BD09 File Offset: 0x00139F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSave
		{
			get
			{
				return this.isSave_;
			}
			set
			{
				this.isSave_ = value;
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x0013BD12 File Offset: 0x00139F12
		// (set) Token: 0x0600770B RID: 30475 RVA: 0x0013BD1A File Offset: 0x00139F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ CustomDrink
		{
			get
			{
				return this.customDrink_;
			}
			set
			{
				this.customDrink_ = value;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600770C RID: 30476 RVA: 0x0013BD23 File Offset: 0x00139F23
		// (set) Token: 0x0600770D RID: 30477 RVA: 0x0013BD2B File Offset: 0x00139F2B
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

		// Token: 0x0600770E RID: 30478 RVA: 0x0013BD34 File Offset: 0x00139F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MakeMissionDrinkScRsp);
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x0013BD44 File Offset: 0x00139F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MakeMissionDrinkScRsp other)
		{
			return other != null && (other == this || (this.IsSucc == other.IsSucc && this.IsSave == other.IsSave && object.Equals(this.CustomDrink, other.CustomDrink) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x0013BDB4 File Offset: 0x00139FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSucc)
			{
				num ^= this.IsSucc.GetHashCode();
			}
			if (this.IsSave)
			{
				num ^= this.IsSave.GetHashCode();
			}
			if (this.customDrink_ != null)
			{
				num ^= this.CustomDrink.GetHashCode();
			}
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

		// Token: 0x06007711 RID: 30481 RVA: 0x0013BE3B File Offset: 0x0013A03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x0013BE43 File Offset: 0x0013A043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x0013BE4C File Offset: 0x0013A04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSave)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSave);
			}
			if (this.customDrink_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CustomDrink);
			}
			if (this.IsSucc)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsSucc);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x0013BEE0 File Offset: 0x0013A0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSucc)
			{
				num += 2;
			}
			if (this.IsSave)
			{
				num += 2;
			}
			if (this.customDrink_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CustomDrink);
			}
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

		// Token: 0x06007715 RID: 30485 RVA: 0x0013BF50 File Offset: 0x0013A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MakeMissionDrinkScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSucc)
			{
				this.IsSucc = other.IsSucc;
			}
			if (other.IsSave)
			{
				this.IsSave = other.IsSave;
			}
			if (other.customDrink_ != null)
			{
				if (this.customDrink_ == null)
				{
					this.CustomDrink = new LGNIOADJNOJ();
				}
				this.CustomDrink.MergeFrom(other.CustomDrink);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x0013BFE0 File Offset: 0x0013A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x0013BFEC File Offset: 0x0013A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 16U)
					{
						this.IsSave = input.ReadBool();
						continue;
					}
					if (num == 82U)
					{
						if (this.customDrink_ == null)
						{
							this.CustomDrink = new LGNIOADJNOJ();
						}
						input.ReadMessage(this.CustomDrink);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.IsSucc = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002DB8 RID: 11704
		private static readonly MessageParser<MakeMissionDrinkScRsp> _parser = new MessageParser<MakeMissionDrinkScRsp>(() => new MakeMissionDrinkScRsp());

		// Token: 0x04002DB9 RID: 11705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DBA RID: 11706
		public const int IsSuccFieldNumber = 14;

		// Token: 0x04002DBB RID: 11707
		private bool isSucc_;

		// Token: 0x04002DBC RID: 11708
		public const int IsSaveFieldNumber = 2;

		// Token: 0x04002DBD RID: 11709
		private bool isSave_;

		// Token: 0x04002DBE RID: 11710
		public const int CustomDrinkFieldNumber = 10;

		// Token: 0x04002DBF RID: 11711
		private LGNIOADJNOJ customDrink_;

		// Token: 0x04002DC0 RID: 11712
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002DC1 RID: 11713
		private uint retcode_;
	}
}
