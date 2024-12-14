using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200007D RID: 125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ALFJMIPDIBO : IMessage<ALFJMIPDIBO>, IMessage, IEquatable<ALFJMIPDIBO>, IDeepCloneable<ALFJMIPDIBO>, IBufferMessage
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0000F805 File Offset: 0x0000DA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ALFJMIPDIBO> Parser
		{
			get
			{
				return ALFJMIPDIBO._parser;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0000F80C File Offset: 0x0000DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ALFJMIPDIBOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000F81E File Offset: 0x0000DA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ALFJMIPDIBO.Descriptor;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000F825 File Offset: 0x0000DA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALFJMIPDIBO()
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000F830 File Offset: 0x0000DA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALFJMIPDIBO(ALFJMIPDIBO other) : this()
		{
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this.eHMEAGKBIID_ = other.eHMEAGKBIID_;
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000F884 File Offset: 0x0000DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALFJMIPDIBO Clone()
		{
			return new ALFJMIPDIBO(this);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0000F88C File Offset: 0x0000DA8C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0000F894 File Offset: 0x0000DA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000F89D File Offset: 0x0000DA9D
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000F8A5 File Offset: 0x0000DAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000F8AE File Offset: 0x0000DAAE
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000F8B6 File Offset: 0x0000DAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHMEAGKBIID
		{
			get
			{
				return this.eHMEAGKBIID_;
			}
			set
			{
				this.eHMEAGKBIID_ = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000F8BF File Offset: 0x0000DABF
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0000F8C7 File Offset: 0x0000DAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ALFJMIPDIBO);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ALFJMIPDIBO other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.Level == other.Level && this.EHMEAGKBIID == other.EHMEAGKBIID && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000F94C File Offset: 0x0000DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.EHMEAGKBIID != 0U)
			{
				num ^= this.EHMEAGKBIID.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000F9D6 File Offset: 0x0000DBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000F9DE File Offset: 0x0000DBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EHMEAGKBIID != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EHMEAGKBIID);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AeonId);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.EHMEAGKBIID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHMEAGKBIID);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000FB04 File Offset: 0x0000DD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ALFJMIPDIBO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.EHMEAGKBIID != 0U)
			{
				this.EHMEAGKBIID = other.EHMEAGKBIID;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.EHMEAGKBIID = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AeonId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040001FA RID: 506
		private static readonly MessageParser<ALFJMIPDIBO> _parser = new MessageParser<ALFJMIPDIBO>(() => new ALFJMIPDIBO());

		// Token: 0x040001FB RID: 507
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001FC RID: 508
		public const int ExpFieldNumber = 14;

		// Token: 0x040001FD RID: 509
		private uint exp_;

		// Token: 0x040001FE RID: 510
		public const int LevelFieldNumber = 6;

		// Token: 0x040001FF RID: 511
		private uint level_;

		// Token: 0x04000200 RID: 512
		public const int EHMEAGKBIIDFieldNumber = 4;

		// Token: 0x04000201 RID: 513
		private uint eHMEAGKBIID_;

		// Token: 0x04000202 RID: 514
		public const int AeonIdFieldNumber = 8;

		// Token: 0x04000203 RID: 515
		private uint aeonId_;
	}
}
