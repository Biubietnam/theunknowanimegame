using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200053B RID: 1339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightKickOutScNotify : IMessage<FightKickOutScNotify>, IMessage, IEquatable<FightKickOutScNotify>, IDeepCloneable<FightKickOutScNotify>, IBufferMessage
	{
		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x000A4291 File Offset: 0x000A2491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightKickOutScNotify> Parser
		{
			get
			{
				return FightKickOutScNotify._parser;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x000A4298 File Offset: 0x000A2498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightKickOutScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x000A42AA File Offset: 0x000A24AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightKickOutScNotify.Descriptor;
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x000A42B1 File Offset: 0x000A24B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightKickOutScNotify()
		{
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x000A42B9 File Offset: 0x000A24B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightKickOutScNotify(FightKickOutScNotify other) : this()
		{
			this.kickType_ = other.kickType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x000A42DE File Offset: 0x000A24DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightKickOutScNotify Clone()
		{
			return new FightKickOutScNotify(this);
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000A42E6 File Offset: 0x000A24E6
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x000A42EE File Offset: 0x000A24EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightKickoutType KickType
		{
			get
			{
				return this.kickType_;
			}
			set
			{
				this.kickType_ = value;
			}
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x000A42F7 File Offset: 0x000A24F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightKickOutScNotify);
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x000A4305 File Offset: 0x000A2505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightKickOutScNotify other)
		{
			return other != null && (other == this || (this.KickType == other.KickType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x000A4334 File Offset: 0x000A2534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KickType != FightKickoutType.FightKickoutUnknown)
			{
				num ^= this.KickType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000A4379 File Offset: 0x000A2579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x000A4381 File Offset: 0x000A2581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000A438A File Offset: 0x000A258A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KickType != FightKickoutType.FightKickoutUnknown)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.KickType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000A43BC File Offset: 0x000A25BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KickType != FightKickoutType.FightKickoutUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KickType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000A43FA File Offset: 0x000A25FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightKickOutScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KickType != FightKickoutType.FightKickoutUnknown)
			{
				this.KickType = other.KickType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000A442B File Offset: 0x000A262B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000A4434 File Offset: 0x000A2634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KickType = (FightKickoutType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001808 RID: 6152
		private static readonly MessageParser<FightKickOutScNotify> _parser = new MessageParser<FightKickOutScNotify>(() => new FightKickOutScNotify());

		// Token: 0x04001809 RID: 6153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400180A RID: 6154
		public const int KickTypeFieldNumber = 12;

		// Token: 0x0400180B RID: 6155
		private FightKickoutType kickType_;
	}
}
