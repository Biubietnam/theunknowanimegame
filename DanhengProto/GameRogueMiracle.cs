using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E5 RID: 1509
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameRogueMiracle : IMessage<GameRogueMiracle>, IMessage, IEquatable<GameRogueMiracle>, IDeepCloneable<GameRogueMiracle>, IBufferMessage
	{
		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x000B72C0 File Offset: 0x000B54C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameRogueMiracle> Parser
		{
			get
			{
				return GameRogueMiracle._parser;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x000B72C7 File Offset: 0x000B54C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRogueMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x000B72D9 File Offset: 0x000B54D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameRogueMiracle.Descriptor;
			}
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x000B72E0 File Offset: 0x000B54E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle()
		{
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x000B72F4 File Offset: 0x000B54F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle(GameRogueMiracle other) : this()
		{
			this.oEOIJBHAINB_ = other.oEOIJBHAINB_.Clone();
			this.curTimes_ = other.curTimes_;
			this.miracleId_ = other.miracleId_;
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x000B734D File Offset: 0x000B554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle Clone()
		{
			return new GameRogueMiracle(this);
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x000B7355 File Offset: 0x000B5555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> OEOIJBHAINB
		{
			get
			{
				return this.oEOIJBHAINB_;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x000B735D File Offset: 0x000B555D
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x000B7365 File Offset: 0x000B5565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurTimes
		{
			get
			{
				return this.curTimes_;
			}
			set
			{
				this.curTimes_ = value;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x000B736E File Offset: 0x000B556E
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x000B7376 File Offset: 0x000B5576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x000B737F File Offset: 0x000B557F
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x000B7387 File Offset: 0x000B5587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Durability
		{
			get
			{
				return this.durability_;
			}
			set
			{
				this.durability_ = value;
			}
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000B7390 File Offset: 0x000B5590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameRogueMiracle);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000B73A0 File Offset: 0x000B55A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameRogueMiracle other)
		{
			return other != null && (other == this || (this.OEOIJBHAINB.Equals(other.OEOIJBHAINB) && this.CurTimes == other.CurTimes && this.MiracleId == other.MiracleId && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x000B7410 File Offset: 0x000B5610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.OEOIJBHAINB.GetHashCode();
			if (this.CurTimes != 0U)
			{
				num ^= this.CurTimes.GetHashCode();
			}
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this.Durability != 0U)
			{
				num ^= this.Durability.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x000B748F File Offset: 0x000B568F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x000B7497 File Offset: 0x000B5697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000B74A0 File Offset: 0x000B56A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Durability != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Durability);
			}
			if (this.CurTimes != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurTimes);
			}
			this.oEOIJBHAINB_.WriteTo(ref output, GameRogueMiracle._map_oEOIJBHAINB_codec);
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x000B7528 File Offset: 0x000B5728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.oEOIJBHAINB_.CalculateSize(GameRogueMiracle._map_oEOIJBHAINB_codec);
			if (this.CurTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurTimes);
			}
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this.Durability != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Durability);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000B75AC File Offset: 0x000B57AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameRogueMiracle other)
		{
			if (other == null)
			{
				return;
			}
			this.oEOIJBHAINB_.MergeFrom(other.oEOIJBHAINB_);
			if (other.CurTimes != 0U)
			{
				this.CurTimes = other.CurTimes;
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			if (other.Durability != 0U)
			{
				this.Durability = other.Durability;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000B7621 File Offset: 0x000B5821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x000B762C File Offset: 0x000B582C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Durability = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurTimes = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.oEOIJBHAINB_.AddEntriesFrom(ref input, GameRogueMiracle._map_oEOIJBHAINB_codec);
						continue;
					}
					if (num == 80U)
					{
						this.MiracleId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AB6 RID: 6838
		private static readonly MessageParser<GameRogueMiracle> _parser = new MessageParser<GameRogueMiracle>(() => new GameRogueMiracle());

		// Token: 0x04001AB7 RID: 6839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AB8 RID: 6840
		public const int OEOIJBHAINBFieldNumber = 8;

		// Token: 0x04001AB9 RID: 6841
		private static readonly MapField<uint, uint>.Codec _map_oEOIJBHAINB_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 66U);

		// Token: 0x04001ABA RID: 6842
		private readonly MapField<uint, uint> oEOIJBHAINB_ = new MapField<uint, uint>();

		// Token: 0x04001ABB RID: 6843
		public const int CurTimesFieldNumber = 2;

		// Token: 0x04001ABC RID: 6844
		private uint curTimes_;

		// Token: 0x04001ABD RID: 6845
		public const int MiracleIdFieldNumber = 10;

		// Token: 0x04001ABE RID: 6846
		private uint miracleId_;

		// Token: 0x04001ABF RID: 6847
		public const int DurabilityFieldNumber = 1;

		// Token: 0x04001AC0 RID: 6848
		private uint durability_;
	}
}
