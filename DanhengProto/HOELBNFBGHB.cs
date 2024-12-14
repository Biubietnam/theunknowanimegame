using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000905 RID: 2309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HOELBNFBGHB : IMessage<HOELBNFBGHB>, IMessage, IEquatable<HOELBNFBGHB>, IDeepCloneable<HOELBNFBGHB>, IBufferMessage
	{
		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06006700 RID: 26368 RVA: 0x00113100 File Offset: 0x00111300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HOELBNFBGHB> Parser
		{
			get
			{
				return HOELBNFBGHB._parser;
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x00113107 File Offset: 0x00111307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HOELBNFBGHBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06006702 RID: 26370 RVA: 0x00113119 File Offset: 0x00111319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HOELBNFBGHB.Descriptor;
			}
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x00113120 File Offset: 0x00111320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HOELBNFBGHB()
		{
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00113128 File Offset: 0x00111328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HOELBNFBGHB(HOELBNFBGHB other) : this()
		{
			this.entityId_ = other.entityId_;
			this.nMKAMJJAPHO_ = other.nMKAMJJAPHO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x00113159 File Offset: 0x00111359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HOELBNFBGHB Clone()
		{
			return new HOELBNFBGHB(this);
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x00113161 File Offset: 0x00111361
		// (set) Token: 0x06006707 RID: 26375 RVA: 0x00113169 File Offset: 0x00111369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x00113172 File Offset: 0x00111372
		// (set) Token: 0x06006709 RID: 26377 RVA: 0x0011317A File Offset: 0x0011137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NMKAMJJAPHO
		{
			get
			{
				return this.nMKAMJJAPHO_;
			}
			set
			{
				this.nMKAMJJAPHO_ = value;
			}
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x00113183 File Offset: 0x00111383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HOELBNFBGHB);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x00113191 File Offset: 0x00111391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HOELBNFBGHB other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NMKAMJJAPHO == other.NMKAMJJAPHO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x001131D0 File Offset: 0x001113D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NMKAMJJAPHO)
			{
				num ^= this.NMKAMJJAPHO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00113228 File Offset: 0x00111428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00113230 File Offset: 0x00111430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x0011323C File Offset: 0x0011143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NMKAMJJAPHO)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NMKAMJJAPHO);
			}
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x00113298 File Offset: 0x00111498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.NMKAMJJAPHO)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x001132E4 File Offset: 0x001114E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HOELBNFBGHB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NMKAMJJAPHO)
			{
				this.NMKAMJJAPHO = other.NMKAMJJAPHO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00113334 File Offset: 0x00111534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00113340 File Offset: 0x00111540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.NMKAMJJAPHO = input.ReadBool();
				}
			}
		}

		// Token: 0x0400278D RID: 10125
		private static readonly MessageParser<HOELBNFBGHB> _parser = new MessageParser<HOELBNFBGHB>(() => new HOELBNFBGHB());

		// Token: 0x0400278E RID: 10126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400278F RID: 10127
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04002790 RID: 10128
		private uint entityId_;

		// Token: 0x04002791 RID: 10129
		public const int NMKAMJJAPHOFieldNumber = 2;

		// Token: 0x04002792 RID: 10130
		private bool nMKAMJJAPHO_;
	}
}
