using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C5 RID: 197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarPresetHp : IMessage<AvatarPresetHp>, IMessage, IEquatable<AvatarPresetHp>, IDeepCloneable<AvatarPresetHp>, IBufferMessage
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0001A458 File Offset: 0x00018658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarPresetHp> Parser
		{
			get
			{
				return AvatarPresetHp._parser;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0001A45F File Offset: 0x0001865F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarPresetHpReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0001A471 File Offset: 0x00018671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarPresetHp.Descriptor;
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001A478 File Offset: 0x00018678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPresetHp()
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001A480 File Offset: 0x00018680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPresetHp(AvatarPresetHp other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.fMHECFJEGIB_ = other.fMHECFJEGIB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001A4B1 File Offset: 0x000186B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarPresetHp Clone()
		{
			return new AvatarPresetHp(this);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0001A4B9 File Offset: 0x000186B9
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x0001A4C1 File Offset: 0x000186C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0001A4CA File Offset: 0x000186CA
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x0001A4D2 File Offset: 0x000186D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FMHECFJEGIB
		{
			get
			{
				return this.fMHECFJEGIB_;
			}
			set
			{
				this.fMHECFJEGIB_ = value;
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0001A4DB File Offset: 0x000186DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarPresetHp);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0001A4E9 File Offset: 0x000186E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarPresetHp other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.FMHECFJEGIB == other.FMHECFJEGIB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0001A528 File Offset: 0x00018728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.FMHECFJEGIB != 0U)
			{
				num ^= this.FMHECFJEGIB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001A580 File Offset: 0x00018780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001A588 File Offset: 0x00018788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001A594 File Offset: 0x00018794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.FMHECFJEGIB != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FMHECFJEGIB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0001A5F0 File Offset: 0x000187F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.FMHECFJEGIB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMHECFJEGIB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0001A648 File Offset: 0x00018848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarPresetHp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.FMHECFJEGIB != 0U)
			{
				this.FMHECFJEGIB = other.FMHECFJEGIB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001A698 File Offset: 0x00018898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001A6A4 File Offset: 0x000188A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FMHECFJEGIB = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400039B RID: 923
		private static readonly MessageParser<AvatarPresetHp> _parser = new MessageParser<AvatarPresetHp>(() => new AvatarPresetHp());

		// Token: 0x0400039C RID: 924
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400039D RID: 925
		public const int AvatarIdFieldNumber = 2;

		// Token: 0x0400039E RID: 926
		private uint avatarId_;

		// Token: 0x0400039F RID: 927
		public const int FMHECFJEGIBFieldNumber = 14;

		// Token: 0x040003A0 RID: 928
		private uint fMHECFJEGIB_;
	}
}
