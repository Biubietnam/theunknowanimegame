using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000543 RID: 1347
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3ChatScNotify : IMessage<FightMatch3ChatScNotify>, IMessage, IEquatable<FightMatch3ChatScNotify>, IDeepCloneable<FightMatch3ChatScNotify>, IBufferMessage
	{
		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x000A4A69 File Offset: 0x000A2C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3ChatScNotify> Parser
		{
			get
			{
				return FightMatch3ChatScNotify._parser;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x000A4A70 File Offset: 0x000A2C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3ChatScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x000A4A82 File Offset: 0x000A2C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3ChatScNotify.Descriptor;
			}
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x000A4A89 File Offset: 0x000A2C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScNotify()
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x000A4A91 File Offset: 0x000A2C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScNotify(FightMatch3ChatScNotify other) : this()
		{
			this.oAOGPLNDOKA_ = other.oAOGPLNDOKA_;
			this.nBPDNFMOLGO_ = other.nBPDNFMOLGO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x000A4AC2 File Offset: 0x000A2CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScNotify Clone()
		{
			return new FightMatch3ChatScNotify(this);
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000A4ACA File Offset: 0x000A2CCA
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x000A4AD2 File Offset: 0x000A2CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OAOGPLNDOKA
		{
			get
			{
				return this.oAOGPLNDOKA_;
			}
			set
			{
				this.oAOGPLNDOKA_ = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x000A4ADB File Offset: 0x000A2CDB
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x000A4AE3 File Offset: 0x000A2CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NBPDNFMOLGO
		{
			get
			{
				return this.nBPDNFMOLGO_;
			}
			set
			{
				this.nBPDNFMOLGO_ = value;
			}
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x000A4AEC File Offset: 0x000A2CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3ChatScNotify);
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x000A4AFA File Offset: 0x000A2CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3ChatScNotify other)
		{
			return other != null && (other == this || (this.OAOGPLNDOKA == other.OAOGPLNDOKA && this.NBPDNFMOLGO == other.NBPDNFMOLGO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x000A4B38 File Offset: 0x000A2D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OAOGPLNDOKA != 0U)
			{
				num ^= this.OAOGPLNDOKA.GetHashCode();
			}
			if (this.NBPDNFMOLGO != 0U)
			{
				num ^= this.NBPDNFMOLGO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000A4B90 File Offset: 0x000A2D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x000A4B98 File Offset: 0x000A2D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x000A4BA4 File Offset: 0x000A2DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OAOGPLNDOKA != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OAOGPLNDOKA);
			}
			if (this.NBPDNFMOLGO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NBPDNFMOLGO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x000A4BFC File Offset: 0x000A2DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OAOGPLNDOKA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OAOGPLNDOKA);
			}
			if (this.NBPDNFMOLGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NBPDNFMOLGO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x000A4C54 File Offset: 0x000A2E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3ChatScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OAOGPLNDOKA != 0U)
			{
				this.OAOGPLNDOKA = other.OAOGPLNDOKA;
			}
			if (other.NBPDNFMOLGO != 0U)
			{
				this.NBPDNFMOLGO = other.NBPDNFMOLGO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x000A4CA4 File Offset: 0x000A2EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x000A4CB0 File Offset: 0x000A2EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NBPDNFMOLGO = input.ReadUInt32();
					}
				}
				else
				{
					this.OAOGPLNDOKA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400181E RID: 6174
		private static readonly MessageParser<FightMatch3ChatScNotify> _parser = new MessageParser<FightMatch3ChatScNotify>(() => new FightMatch3ChatScNotify());

		// Token: 0x0400181F RID: 6175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001820 RID: 6176
		public const int OAOGPLNDOKAFieldNumber = 1;

		// Token: 0x04001821 RID: 6177
		private uint oAOGPLNDOKA_;

		// Token: 0x04001822 RID: 6178
		public const int NBPDNFMOLGOFieldNumber = 9;

		// Token: 0x04001823 RID: 6179
		private uint nBPDNFMOLGO_;
	}
}
