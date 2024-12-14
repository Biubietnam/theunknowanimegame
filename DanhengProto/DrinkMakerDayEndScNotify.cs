using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E3 RID: 995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DrinkMakerDayEndScNotify : IMessage<DrinkMakerDayEndScNotify>, IMessage, IEquatable<DrinkMakerDayEndScNotify>, IDeepCloneable<DrinkMakerDayEndScNotify>, IBufferMessage
	{
		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0007AF70 File Offset: 0x00079170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMakerDayEndScNotify> Parser
		{
			get
			{
				return DrinkMakerDayEndScNotify._parser;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x0007AF77 File Offset: 0x00079177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DrinkMakerDayEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0007AF89 File Offset: 0x00079189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMakerDayEndScNotify.Descriptor;
			}
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0007AF90 File Offset: 0x00079190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerDayEndScNotify()
		{
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0007AF98 File Offset: 0x00079198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerDayEndScNotify(DrinkMakerDayEndScNotify other) : this()
		{
			this.oKJCKFKADFC_ = other.oKJCKFKADFC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0007AFBD File Offset: 0x000791BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMakerDayEndScNotify Clone()
		{
			return new DrinkMakerDayEndScNotify(this);
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x0007AFC5 File Offset: 0x000791C5
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x0007AFCD File Offset: 0x000791CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKJCKFKADFC
		{
			get
			{
				return this.oKJCKFKADFC_;
			}
			set
			{
				this.oKJCKFKADFC_ = value;
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0007AFD6 File Offset: 0x000791D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMakerDayEndScNotify);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x0007AFE4 File Offset: 0x000791E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMakerDayEndScNotify other)
		{
			return other != null && (other == this || (this.OKJCKFKADFC == other.OKJCKFKADFC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0007B014 File Offset: 0x00079214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKJCKFKADFC != 0U)
			{
				num ^= this.OKJCKFKADFC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0007B053 File Offset: 0x00079253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0007B05B File Offset: 0x0007925B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0007B064 File Offset: 0x00079264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKJCKFKADFC != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OKJCKFKADFC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0007B098 File Offset: 0x00079298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKJCKFKADFC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKJCKFKADFC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0007B0D6 File Offset: 0x000792D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMakerDayEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKJCKFKADFC != 0U)
			{
				this.OKJCKFKADFC = other.OKJCKFKADFC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0007B107 File Offset: 0x00079307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0007B110 File Offset: 0x00079310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OKJCKFKADFC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011E3 RID: 4579
		private static readonly MessageParser<DrinkMakerDayEndScNotify> _parser = new MessageParser<DrinkMakerDayEndScNotify>(() => new DrinkMakerDayEndScNotify());

		// Token: 0x040011E4 RID: 4580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011E5 RID: 4581
		public const int OKJCKFKADFCFieldNumber = 1;

		// Token: 0x040011E6 RID: 4582
		private uint oKJCKFKADFC_;
	}
}
